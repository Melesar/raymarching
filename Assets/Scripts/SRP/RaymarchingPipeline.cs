using System.Diagnostics;
using Melesar.Raymarching.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Melesar.Raymarching.SRP
{
    public class RaymarchingPipeline : RenderPipeline
    {
        private readonly PipelineConfig m_config;
        private readonly Raymarcher m_raymarcher;
        private readonly Material _screenQuadMaterial;
        private readonly RenderTargetsRepository _renderTargetsRepository;

        private static readonly int _mainTex = Shader.PropertyToID("_MainTex");

        protected override void Render(ScriptableRenderContext context, Camera[] cameras)
        {
            BeginFrameRendering(context, cameras);
            foreach (Camera camera in cameras)
            {
                DrawCamera(context, camera);
            }

            context.Submit();
            EndFrameRendering(context, cameras);
        }

        private void DrawCamera(ScriptableRenderContext context, Camera camera)
        {
            BeginCameraRendering(context, camera);
            context.SetupCameraProperties(camera);

            if (camera.cameraType != CameraType.SceneView)
            {
                DrawGameView(context, camera);
            }
            else
            {
                DrawSceneView(context, camera);
            }

#if UNITY_EDITOR
            if (UnityEditor.Handles.ShouldRenderGizmos())
            {
                context.DrawGizmos(camera, GizmoSubset.PostImageEffects);
                context.DrawGizmos(camera, GizmoSubset.PreImageEffects);
            }
#endif
            EndCameraRendering(context, camera);
        }

        private void DrawGameView(ScriptableRenderContext context, Camera camera)
        {
            RenderTexture renderTarget = _renderTargetsRepository.GetRT(camera);
            CommandBuffer commands = CommandBufferPool.Get(camera.name);
            commands.SetRenderTarget(renderTarget);
            commands.ClearRenderTarget(true, true, Color.black);
            ExecuteBuffer(context, commands);
            context.DrawSkybox(camera);

            commands.BeginSample("Raymarching");
            m_raymarcher.BeginCamera(camera);
            m_raymarcher.Render(commands, renderTarget);
            commands.EndSample("Raymarching");
            ExecuteBuffer(context, commands);
            m_raymarcher.EndCamera();

            commands.SetRenderTarget((RenderTexture) null);
            RenderScreenQuad(commands, renderTarget);
            ExecuteBuffer(context, commands);

            CommandBufferPool.Release(commands);
        }

        [Conditional("UNITY_EDITOR")]
        private void DrawSceneView(ScriptableRenderContext context, Camera camera)
        {
            CommandBuffer commands = CommandBufferPool.Get(camera.name);
            commands.ClearRenderTarget(true, true, Color.clear);
            ExecuteBuffer(context, commands);
            context.DrawSkybox(camera);
            CommandBufferPool.Release(commands);

            ScriptableRenderContext.EmitWorldGeometryForSceneView(camera);
        }

        private static void ExecuteBuffer(ScriptableRenderContext context, CommandBuffer commands)
        {
            context.ExecuteCommandBuffer(commands);
            commands.Clear();
        }

        private void RenderScreenQuad(CommandBuffer commands, Texture texture)
        {
            _screenQuadMaterial.SetTexture(_mainTex, texture);
            commands.DrawMesh(RenderingUtils.fullscreenMesh, Matrix4x4.identity, _screenQuadMaterial);
        }

        public RaymarchingPipeline(PipelineConfig config)
        {
            m_config = config;
            m_raymarcher = new Raymarcher(m_config.shader, m_config.shapes);
            _screenQuadMaterial = new Material(config.screenQuadShader);
            _renderTargetsRepository = new RenderTargetsRepository();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            m_raymarcher.Dispose();
            _renderTargetsRepository.Dispose();
            Object.DestroyImmediate(_screenQuadMaterial);
        }
    }
}
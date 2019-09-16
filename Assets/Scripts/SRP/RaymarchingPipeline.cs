using Melesar.Raymarching.Shapes;
using UnityEngine;
using UnityEngine.Rendering;

namespace Melesar.Raymarching.SRP
{
	public class RaymarchingPipeline : RenderPipeline
	{
		private readonly PipelineConfig m_config;
		private Raymarcher m_raymarcher;

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

			m_raymarcher.Populate(m_config.shapes, camera);
			m_raymarcher.Render(context);
			
			context.DrawGizmos(camera, GizmoSubset.PostImageEffects);
			context.DrawGizmos(camera, GizmoSubset.PreImageEffects);
			context.DrawSkybox(camera);
			EndCameraRendering(context, camera);
		}

		public RaymarchingPipeline(PipelineConfig config)
		{
			m_config = config;
			m_raymarcher = new Raymarcher(m_config.shader);
		}
	}
}

using System;
using System.Collections.Generic;
using Melesar.Raymarching.Shapes;
using Melesar.Raymarching.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Melesar.Raymarching
{
    [RequireComponent(typeof(Camera))]
    public class DefaultPipelineTest : MonoBehaviour
    {
        [SerializeField] private ShapesCollection _shapes;
        [SerializeField] private ComputeShader _computeShader;
        [SerializeField] private RawImage _image;
        
        
        private Raymarcher _raymarcher;
        private Camera _camera;
        private RenderTexture _renderTexture;
            
        private static readonly int CamToWorldMatrixProp = Shader.PropertyToID("_CameraToWorld");
        private static readonly int InvProjectionMatrixProp = Shader.PropertyToID("_CameraInverseProjection");
        private static readonly int DestinationTextureProp = Shader.PropertyToID("Destination");
        private static readonly int BufferProp = Shader.PropertyToID("shapes");
        private static readonly int BufferLengthProp = Shader.PropertyToID("numShapes");
        
        private void Update()
        {
            RenderWithRaymarcher();
        }

        private void RenderWithRaymarcher()
        {
            using (var commandBuffer = new CommandBuffer {name = "Raymarching"})
            {
                _raymarcher.BeginCamera(_camera);
                _raymarcher.Render(commandBuffer, _renderTexture);
                Graphics.ExecuteCommandBuffer(commandBuffer);
                _raymarcher.EndCamera();
            }
        }

        private void RenderInPlace()
        {
            var shapesData = new List<ShapeData>();
            _shapes.GetShapeData(shapesData);

            _computeShader.SetMatrix(CamToWorldMatrixProp, _camera.cameraToWorldMatrix);
            _computeShader.SetMatrix(InvProjectionMatrixProp, _camera.projectionMatrix.inverse);
            _computeShader.SetTexture(0, DestinationTextureProp, _renderTexture);

            if (shapesData.Count > 0)
            {
                using (var computeBuffer = new ComputeBuffer(shapesData.Count, ShapeData.GetStructSize()))
                {
                    int threadGroupsX = Mathf.CeilToInt((float) _camera.pixelWidth / 8);
                    int threadGroupsY = Mathf.CeilToInt((float) _camera.pixelHeight / 8);
                    computeBuffer.SetData(shapesData);
                    _computeShader.SetBuffer(0, BufferProp, computeBuffer);
                    _computeShader.SetInt(BufferLengthProp, computeBuffer.count);
                    _computeShader.Dispatch(0, threadGroupsX, threadGroupsY, 1);
                }
            }
        }

        private void Awake()
        {
            _camera = GetComponent<Camera>();
            _raymarcher = new Raymarcher(_computeShader, _shapes);
            
            var descriptor = new RenderTextureDescriptor(_camera.pixelWidth, _camera.pixelHeight)
            {
                enableRandomWrite = true,
                colorFormat = RenderTextureFormat.ARGBFloat,
                depthBufferBits = 0,
            };
            _renderTexture = new RenderTexture(descriptor);
            _renderTexture.Create();
            _image.texture = _renderTexture;
        }

        private void OnDestroy()
        {
            Destroy(_renderTexture);
        }
    }
}
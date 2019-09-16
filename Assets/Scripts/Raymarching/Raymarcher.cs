using System;
using System.Collections.Generic;
using Melesar.Raymarching.Shapes;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Melesar.Raymarching
{
	public class Raymarcher
	{
		private readonly ComputeShader m_shader;
		private readonly List<ShapeData> m_shapeData = new List<ShapeData>();

		private int m_threadGroupsX;
		private int m_threadGroupsY;
		
		private ShapesCollection m_shapes;
		private CommandBuffer m_commandBuffer;
		private RenderTexture m_renderTarget;
		private RenderTextureDescriptor m_renderTargetDescriptor;
		private Camera m_camera;

		private static readonly int CamToWorldMatrixProp = Shader.PropertyToID("_CameraToWorld");
		private static readonly int InvProjectionMatrixProp = Shader.PropertyToID("_CameraInverseProjection");
		private static readonly int DestinationTextureProp = Shader.PropertyToID("Destination");
		private static readonly int BufferProp = Shader.PropertyToID("shapes");
		private static readonly int BufferLengthProp = Shader.PropertyToID("numShapes");

		private const int THREADS_PER_GROUP = 8;
		
		public void Populate(ShapesCollection shapes, Camera camera)
		{
			m_camera = camera;
			m_shapes = shapes;
			
			m_threadGroupsX = Mathf.CeilToInt((float) camera.pixelWidth / THREADS_PER_GROUP);
			m_threadGroupsY = Mathf.CeilToInt((float) camera.pixelHeight / THREADS_PER_GROUP);
			
			m_renderTargetDescriptor = new RenderTextureDescriptor(m_camera.pixelWidth, m_camera.pixelHeight) {enableRandomWrite = true};
		}

		public void Render(ScriptableRenderContext context)
		{
			m_commandBuffer = CommandBufferPool.Get("Raymarching");
			m_renderTarget = RenderTexture.GetTemporary(m_renderTargetDescriptor);
			
			m_shapes.GetShapeData(m_shapeData);
			
			SetShaderProperties();
			
			m_commandBuffer.ClearRenderTarget(false, true, Color.gray);
			m_commandBuffer.SetRenderTarget(m_renderTarget);

			if (m_shapeData.Count > 0)
			{
				using (var buffer = new ComputeBuffer(m_shapeData.Count, ShapeData.GetStructSize()))
				{
					buffer.SetData(m_shapeData);
					m_commandBuffer.SetComputeBufferParam(m_shader, 0, BufferProp, buffer);
					m_commandBuffer.SetComputeIntParam(m_shader, BufferLengthProp, buffer.count);
					m_commandBuffer.DispatchCompute(m_shader, 0, m_threadGroupsX, m_threadGroupsY, 1);
				}
			}
			
			context.ExecuteCommandBuffer(m_commandBuffer);
			
			RenderTexture.ReleaseTemporary(m_renderTarget);
			CommandBufferPool.Release(m_commandBuffer);
		}

		private void SetShaderProperties()
		{
			m_commandBuffer.SetComputeMatrixParam(m_shader, CamToWorldMatrixProp, m_camera.cameraToWorldMatrix);
			m_commandBuffer.SetComputeMatrixParam(m_shader, InvProjectionMatrixProp, m_camera.projectionMatrix.inverse);
			m_commandBuffer.SetComputeTextureParam(m_shader, 0, DestinationTextureProp, m_renderTarget);
		}

		public Raymarcher(ComputeShader shader)
		{
			m_shader = shader;
		}
	}
}

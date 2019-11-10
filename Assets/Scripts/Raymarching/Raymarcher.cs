using System;
using System.Collections.Generic;
using Melesar.Raymarching.Shapes;
using Melesar.Raymarching.Utils;
using UnityEngine;
using UnityEngine.Rendering;
using Object = UnityEngine.Object;

namespace Melesar.Raymarching
{
	public class Raymarcher : IDisposable
	{
		private readonly ComputeShader m_shader;
		private readonly List<ShapeData> m_shapeData = new List<ShapeData>();
		private readonly RenderTargetsRepository _renderTargetsRepository = new RenderTargetsRepository();

		private int m_threadGroupsX;
		private int m_threadGroupsY;
		
		private ShapesCollection m_shapes;
		private RenderTexture m_renderTarget;
		private Camera m_camera;
		private ComputeBuffer _buffer;

		private static readonly int CamToWorldMatrixProp = Shader.PropertyToID("_CameraToWorld");
		private static readonly int InvProjectionMatrixProp = Shader.PropertyToID("_CameraInverseProjection");
		private static readonly int DestinationTextureProp = Shader.PropertyToID("Destination");
		private static readonly int SourceTextureProp = Shader.PropertyToID("Source");
		private static readonly int BufferProp = Shader.PropertyToID("shapes");
		private static readonly int BufferLengthProp = Shader.PropertyToID("numShapes");

		private const int THREADS_PER_GROUP = 8;
		
		public void BeginCamera(Camera camera)
		{
			m_camera = camera;
			m_threadGroupsX = Mathf.CeilToInt((float) camera.pixelWidth / THREADS_PER_GROUP);
			m_threadGroupsY = Mathf.CeilToInt((float) camera.pixelHeight / THREADS_PER_GROUP);

			m_renderTarget = _renderTargetsRepository.GetRT(camera);
			
			m_shapeData.Clear();
			m_shapes.GetShapeData(m_shapeData);
			_buffer = new ComputeBuffer(m_shapeData.Count, ShapeData.GetStructSize());
			_buffer.SetData(m_shapeData);
		}

		public void Render(CommandBuffer commandBuffer, Texture sourceTexture)
		{
			commandBuffer.SetComputeMatrixParam(m_shader, CamToWorldMatrixProp, m_camera.cameraToWorldMatrix);
			commandBuffer.SetComputeMatrixParam(m_shader, InvProjectionMatrixProp, m_camera.projectionMatrix.inverse);
			commandBuffer.SetComputeTextureParam(m_shader, 0, DestinationTextureProp, sourceTexture);
			
			if (m_shapeData.Count > 0)
			{
				commandBuffer.SetComputeBufferParam(m_shader, 0, BufferProp, _buffer);
				commandBuffer.SetComputeIntParam(m_shader, BufferLengthProp, _buffer.count);
				commandBuffer.DispatchCompute(m_shader, 0, m_threadGroupsX, m_threadGroupsY, 1);
			}
		}

		public void EndCamera()
		{
//			_buffer.Release();
		}

		public Raymarcher(ComputeShader shader, ShapesCollection shapes)
		{
			m_shader = shader;
			m_shapes = shapes;
		}

		public void Dispose()
		{
			_renderTargetsRepository.Dispose();
			_buffer.Dispose();
		}
	}
}

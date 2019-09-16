using System;
using System.Collections.Generic;
using Melesar.Raymarching.Shapes;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Camera))]
public class ComputeMaster : MonoBehaviour
{
	[SerializeField] private ComputeShader m_shader;

	private Camera m_camera;
	private int m_bufferStride;
	private int m_threadGroupsX;
	private int m_threadGroupsY;
	
	private static readonly List<Melesar.Raymarching.Shapes.Shape> m_shapes = new List<Melesar.Raymarching.Shapes.Shape>();
	private static ShapeData[] m_shapeData;

	public static ShapeData[] GetShapes()
	{
		return m_shapeData;
	}

	public static void AddShape(Melesar.Raymarching.Shapes.Shape shape)
	{
		m_shapes.Add(shape);
		SetShapeData();
	}

	public static void RemoveShape(Melesar.Raymarching.Shapes.Shape shape)
	{
		m_shapes.Remove(shape);
		SetShapeData();
	}
	
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		RenderTexture shaderTarget = GetRenderTexture();
		
		m_shader.SetTexture(0, "Source", src);
		m_shader.SetTexture(0, "Destination", shaderTarget);
		
		using (var buffer = new ComputeBuffer(m_shapes.Count, m_bufferStride))
		{
			buffer.SetData(m_shapeData);
			m_shader.SetInt("numShapes", m_shapes.Count);
			m_shader.SetBuffer(0, "shapes", buffer);
			m_shader.Dispatch (0, m_threadGroupsX, m_threadGroupsY, 1);
		}

		Graphics.Blit(shaderTarget, dest);
		RenderTexture.ReleaseTemporary(shaderTarget);
	}

	private RenderTexture GetRenderTexture()
	{
		RenderTexture texture = RenderTexture.GetTemporary(m_camera.pixelWidth, m_camera.pixelHeight);
		texture.enableRandomWrite = true;
		texture.Create();

		return texture;
	}

	private void Start()
	{
		m_shader.SetMatrix("_CameraToWorld", m_camera.cameraToWorldMatrix);
		m_shader.SetMatrix("_CameraInverseProjection", m_camera.projectionMatrix.inverse);
	}

	private void Awake()
	{
		m_camera = GetComponent<Camera>();
		
		m_threadGroupsX = 
		m_threadGroupsY = Mathf.CeilToInt (m_camera.pixelHeight / 8.0f);

		m_bufferStride = ShapeData.GetStructSize();
	}

	private static void SetShapeData()
	{
		m_shapeData = new ShapeData[m_shapes.Count];
		for (int i = 0; i < m_shapeData.Length; i++)
		{
			m_shapeData[i] = m_shapes[i].GetData();
		}
	}
}

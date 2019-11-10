using System;
using UnityEngine;

namespace Melesar.Raymarching.Shapes
{
	[ExecuteInEditMode]
	public abstract class Shape : MonoBehaviour
	{
		[SerializeField] private ShapesCollection m_shapes;
		[SerializeField] protected BlendOperation m_blend;
		
		public abstract ShapeData GetData();

		private void OnDisable()
		{
			m_shapes.RemoveShape(this);
		}

		private void OnEnable()
		{
			m_shapes.AddShape(this);
		}
	}
}

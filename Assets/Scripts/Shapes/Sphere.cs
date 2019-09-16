using System;
using UnityEngine;

namespace Melesar.Raymarching.Shapes
{
	public class Sphere : Shape
	{
		[SerializeField] private float m_radius;
		
		public override ShapeData GetData()
		{
			return ShapeDataFactory.CreateSphere(transform.position, m_radius, m_blend);
		}

		private void OnDrawGizmos()
		{
			Gizmos.color = Color.green;
			Gizmos.DrawWireSphere(transform.position, m_radius);
		}
	}
}

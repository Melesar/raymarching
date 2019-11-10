using UnityEngine;

namespace Melesar.Raymarching.Shapes
{
	public class Prism : Shape
	{
		[SerializeField] private Vector3 m_size;

		public Vector3 Size => Vector3.Scale(m_size, transform.localScale);
		
		public override ShapeData GetData()
		{
			return ShapeDataFactory.CreatePrism(transform.position, Size, BlendOperation.Add);
		}
		
		private void OnDrawGizmos()
		{
			Gizmos.color = Color.green;
			Gizmos.DrawWireCube(transform.position, 2 * Size);
		}
	}
}

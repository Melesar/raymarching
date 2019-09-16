using UnityEngine;

namespace Melesar.Raymarching.Shapes
{
	public static class ShapeDataFactory
	{
		public static ShapeData CreateSphere(Vector3 center, float radius, BlendOperation blend)
		{
			return new ShapeData
			{
				shapeType = (int)ShapeType.Sphere,
				operation = (int)blend,
				position = center,
				size = new Vector4(radius, 0f),
			};
		}

		public static ShapeData CreatePrism(Vector3 center, Vector3 size, BlendOperation blend)
		{
			return new ShapeData
			{
				shapeType = (int) ShapeType.Prism,
				operation = (int) blend,
				position = center,
				size = size,
			};
		}
	}
}

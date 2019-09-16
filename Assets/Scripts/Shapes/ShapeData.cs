using UnityEngine;

namespace Melesar.Raymarching.Shapes
{
	public struct ShapeData
	{
		public int shapeType;
		public int operation;
		public Vector3 position;
		public Vector4 size;

		public static int GetStructSize()
		{
			return 4 * (2 + 3 + 4);
		}
	}
}

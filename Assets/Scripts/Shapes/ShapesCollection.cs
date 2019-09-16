using System.Collections.Generic;
using UnityEngine;

namespace Melesar.Raymarching.Shapes
{
	[CreateAssetMenu(menuName = "Raymarching/Shapes collection")]
	public class ShapesCollection : ScriptableObject
	{
		private readonly HashSet<Shape> m_shapes = new HashSet<Shape>();
		
		
		public void GetShapeData(List<ShapeData> shapes)
		{
			int index = 0;
			foreach (Shape shape in m_shapes)
			{
				ShapeData data = shape.GetData();
				if (index < shapes.Count)
				{
					shapes[index] = data;
				}
				else
				{
					shapes.Add(data);
				}

				index++;
			}
		}
		
		public void AddShape(Shape shape)
		{
			m_shapes.Add(shape);
		}

		public void RemoveShape(Shape shape)
		{
			m_shapes.Remove(shape);
		}
	}
}

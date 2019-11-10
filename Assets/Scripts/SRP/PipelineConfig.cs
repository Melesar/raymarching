using Melesar.Raymarching.Shapes;
using UnityEngine;

namespace Melesar.Raymarching.SRP
{
	public struct PipelineConfig
	{
		public ComputeShader shader;
		public ShapesCollection shapes;
		public Shader screenQuadShader;
	}
}

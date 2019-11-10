using Melesar.Raymarching.Shapes;
using UnityEngine;
using UnityEngine.Rendering;

namespace Melesar.Raymarching.SRP
{
	[CreateAssetMenu(menuName = "Rendering/Raymarching pipeline")]
	public class RaymarchingPipelineAsset : RenderPipelineAsset
	{
		[SerializeField] private ComputeShader m_shader;
		[SerializeField] private ShapesCollection m_shapes;
		[SerializeField] private Shader _screenQuadShader;
		
		
		protected override RenderPipeline CreatePipeline()
		{
			return new RaymarchingPipeline(new PipelineConfig
			{
				shader = m_shader,
				shapes = m_shapes,
				screenQuadShader = _screenQuadShader,
			});
		}
	}
}

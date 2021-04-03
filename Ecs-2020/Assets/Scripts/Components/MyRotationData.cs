using Unity.Entities;
using Unity.Mathematics;

namespace Components
{
	[GenerateAuthoringComponent]
	public struct MyRotationData : IComponentData
	{
		public float3 rotationSpeedOnAxes;
	}
}
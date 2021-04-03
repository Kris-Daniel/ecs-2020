using Unity.Entities;
using Unity.Mathematics;

namespace Components
{
	[GenerateAuthoringComponent]
	public struct TargetData : IComponentData
	{
		public Entity followEntity;
		public Entity lookAtEntity;
		public float3 targetOffset;
	}
}
using Unity.Entities;

namespace Components
{
	[GenerateAuthoringComponent]
	public struct TargetData : IComponentData
	{
		public Entity FollowEntity;
		public Entity LookAtEntity;
	}
}
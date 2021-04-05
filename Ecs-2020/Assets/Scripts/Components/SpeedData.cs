using Unity.Entities;

namespace Components
{
	[GenerateAuthoringComponent]
	public struct SpeedData : IComponentData
	{
		public float speed;
	}
}
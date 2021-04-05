using Unity.Entities;

namespace Components
{
	[GenerateAuthoringComponent]
	public struct AliveData : IComponentData
	{
		public bool isAlive;
	}
}
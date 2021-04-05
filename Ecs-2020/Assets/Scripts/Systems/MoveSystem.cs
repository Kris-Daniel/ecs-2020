using Components;
using Unity.Entities;
using Unity.Transforms;

namespace Systems
{
	public class MoveSystem : SystemBase
	{
		protected override void OnUpdate()
		{
			float deltaTime = Time.DeltaTime;
			
			Entities.ForEach((ref Translation translation, in SpeedData moveData) =>
			{
				//translation.Value += moveData.targetDirection * moveData.speed * deltaTime;
			}).Schedule();
		}
	}
}
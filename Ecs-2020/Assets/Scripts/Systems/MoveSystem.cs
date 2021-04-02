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
			
			Entities.ForEach((ref Translation translation, in MoveData moveData) =>
			{
				translation.Value += moveData.TargetDirection * moveData.MoveSpeed * deltaTime;
			}).Schedule();
		}
	}
}
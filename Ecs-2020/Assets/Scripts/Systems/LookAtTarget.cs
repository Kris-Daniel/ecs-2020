using Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Systems
{
	public class LookAtTarget : SystemBase
	{
		protected override void OnUpdate()
		{
			Entities.ForEach((ref RotateData rotateData, in Translation translation, in TargetData targetData) =>
			{
				ComponentDataFromEntity<Translation> translationArray = GetComponentDataFromEntity<Translation>(true);
				if (!translationArray.HasComponent(targetData.LookAtEntity))
				{
					return;
				}

				Translation targetPosition = translationArray[targetData.LookAtEntity];

				rotateData.RotateTargetPosition = targetPosition.Value - translation.Value;
				rotateData.RotateTargetPosition = new float3(rotateData.RotateTargetPosition.x, 0, rotateData.RotateTargetPosition.z);
			}).Schedule();
		}
	}
}
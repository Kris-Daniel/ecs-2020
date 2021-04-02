﻿using Components;
using Unity.Entities;
using Unity.Transforms;

namespace Systems
{
	public class FollowTarget : SystemBase
	{
		protected override void OnUpdate()
		{
			Entities.ForEach((ref MoveData moveData, in TargetData targetData, in Translation translation) =>
			{
				ComponentDataFromEntity<Translation> translationArray = GetComponentDataFromEntity<Translation>(true);
				if (!translationArray.HasComponent(targetData.FollowEntity))
				{
					return;
				}

				Translation targetPosition = translationArray[targetData.FollowEntity];

				moveData.TargetDirection = targetPosition.Value - translation.Value;

			}).Schedule();
		}
	}
}


























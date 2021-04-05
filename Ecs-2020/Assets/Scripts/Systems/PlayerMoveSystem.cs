using Components;
using Components.Tags;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Systems
{
	public class PlayerMoveSystem : SystemBase
	{
		protected override void OnUpdate()
		{
			float deltaTime = Time.DeltaTime;
			float ver = Input.GetAxis("Vertical");
			float hor = Input.GetAxis("Horizontal");
			
			Entities.ForEach((ref Translation translation, in SpeedData speedData, in PlayerTag playerTag) =>
			{
				translation.Value += new float3(hor, 0, ver) * (speedData.speed * deltaTime);
			}).Schedule();
		}
	}
}
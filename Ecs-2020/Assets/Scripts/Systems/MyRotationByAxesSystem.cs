using Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Systems
{
	public class MyRotationByAxesSystem : SystemBase
	{
		protected override void OnUpdate()
		{
			float deltaTime = Time.DeltaTime;
			
			Entities.ForEach((ref Rotation rotation, in MyRotationData rotationData) =>
			{
				rotation.Value = math.mul(rotation.Value, quaternion.Euler(rotationData.rotationSpeedOnAxes * deltaTime));
			}).Schedule();
		}
	}
}
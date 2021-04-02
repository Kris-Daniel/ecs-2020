using Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Systems
{
	public class RotateTowards : SystemBase
	{
		protected override void OnUpdate()
		{
			Entities.ForEach((ref Rotation rotation, in RotateData rotateData) =>
			{
				if (!rotateData.RotateTargetPosition.Equals(float3.zero))
				{
					quaternion targetRotation = quaternion.LookRotationSafe(rotateData.RotateTargetPosition, math.up());
					rotation.Value = math.slerp(rotation.Value, targetRotation, rotateData.RotationSpeed);
				}
			}).Schedule();
		}
	}
}
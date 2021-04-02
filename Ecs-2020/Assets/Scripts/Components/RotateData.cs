using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Components
{
	[GenerateAuthoringComponent]
	public struct RotateData : IComponentData
	{
		[HideInInspector] public float3 RotateTargetPosition;
		public float RotationSpeed;
	}
}
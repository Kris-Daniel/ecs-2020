﻿using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Components
{
	[GenerateAuthoringComponent]
	public struct MoveData : IComponentData
	{
		[HideInInspector] public float3 targetDirection;
		public float moveSpeed;
	}
}
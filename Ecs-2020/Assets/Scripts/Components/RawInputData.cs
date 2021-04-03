using Unity.Entities;
using UnityEngine;

namespace Components
{
	[GenerateAuthoringComponent]
	public struct RawInputData : IComponentData
	{
		[HideInInspector] public float inputH;
		[HideInInspector] public float inputV;
	}
}

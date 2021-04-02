using Unity.Entities;
using UnityEngine;

namespace Components
{
	[GenerateAuthoringComponent]
	public struct RawInputData : IComponentData
	{
		[HideInInspector] public float InputH;
		[HideInInspector] public float InputV;
	}
}

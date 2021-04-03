using System;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Utils
{
	public class Spawner : MonoBehaviour
	{
		[SerializeField] GameObject prefab;

		void Start()
		{
			var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
			var blob = new BlobAssetStore();
			var settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, blob);
			var entityPrefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(prefab, settings);

			var entity = entityManager.Instantiate(entityPrefab);
			entityManager.AddComponentData(entity, new Translation
			{
				Value = new float3(10, 10, 10)
			});
		}
	}
}
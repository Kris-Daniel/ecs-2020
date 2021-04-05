using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Utils
{
	public class Spawner : MonoBehaviour
	{
		[SerializeField] GameObject prefab;

		static BlobAssetStore Blob;
		
		void Start()
		{
			/*Blob = new BlobAssetStore();
			var settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, Blob);
			var entityPrefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(prefab, settings);
			var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;*/

			var a = ConvertToEntity.Instantiate(prefab);
			
			
			
			

			/*var entity = entityManager.Instantiate(entityPrefab);
			entityManager.AddComponentData(entity, new Translation
			{
				Value = new float3(10, 10, 10)
			});*/
		}
	}
}
using Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Utils
{
	public class ConvertCamera : MonoBehaviour, IConvertGameObjectToEntity
	{
		public EntityManager entityManager;
		public Entity targetEntity, lookAtEntity;
		public float3 offset;
		public float moveSpeed;
		public float rotateSpeed;

		void Awake()
		{
			entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
		}

		public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
		{
			dstManager.AddComponent<CopyTransformToGameObject>(entity);
			
			dstManager.AddComponentData(entity, new MoveData{ moveSpeed = moveSpeed });
			dstManager.AddComponentData(entity, new RotateData{ rotationSpeed = rotateSpeed });
			dstManager.AddComponentData(entity, new TargetData{ followEntity = targetEntity, lookAtEntity = lookAtEntity, targetOffset = offset});
		}
	}
}
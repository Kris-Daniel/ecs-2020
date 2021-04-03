﻿using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace Utils
{
	public class SetPlayerCam : MonoBehaviour, IConvertGameObjectToEntity
	{
		public GameObject cameraObject;
		public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
		{
			dstManager.AddComponent<CopyTransformToGameObject>(entity);
			
			ConvertCamera convertCamera = cameraObject.GetComponent<ConvertCamera>();

			if (convertCamera == null)
			{
				convertCamera = cameraObject.AddComponent<ConvertCamera>();
			}

			convertCamera.targetEntity = entity;
		}
	}
}
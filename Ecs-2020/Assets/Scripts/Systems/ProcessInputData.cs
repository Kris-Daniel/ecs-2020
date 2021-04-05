using Components;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Systems
{
    public class ProcessInputData : SystemBase
    {
        protected override void OnUpdate()
        {
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");
            
            // ref is writing, in is for reading
            
            Entities.ForEach((ref RawInputData input, ref SpeedData moveData, ref RotateData rotateData) =>
            {
                input.inputH = inputH;
                input.inputV = inputV;
                
                //moveData.targetDirection = new float3(input.inputH, 0, input.inputV);
                //rotateData.rotateTargetPosition = moveData.targetDirection;
            }).Schedule();
        }
    }
}

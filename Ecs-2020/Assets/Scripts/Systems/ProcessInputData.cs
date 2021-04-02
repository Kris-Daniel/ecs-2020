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
            
            Entities.ForEach((ref RawInputData input, ref MoveData moveData, ref RotateData rotateData) =>
            {
                input.InputH = inputH;
                input.InputV = inputV;
                
                moveData.TargetDirection = new float3(input.InputH, 0, input.InputV);
                rotateData.RotateTargetPosition = moveData.TargetDirection;
            }).Schedule();
        }
    }
}

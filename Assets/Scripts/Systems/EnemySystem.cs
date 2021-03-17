using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using Unity.Physics;
using Unity.Physics.Systems;

public class EnemySystem : SystemBase
{
    /*/
    protected override void OnUpdate()
    {
        var raycaster = new MovementRayCast();
        Entities.ForEach((ref Movement mov, ref Enemy enemy, in Translation trns) =>
        {
            if (math.distance(trns.Value, enemy.previousCell) > 0.9f)
            {
                enemy.previousCell = math.round(trns.Value);


                raycaster.CheckRay();
            }
        }).Schedule();
    }

    
    private struct MovementRayCast
    {
        public PhysicsWorld pw;

        public bool CheckRay(float3 pos, float3 direction, float currentDirection)
        {
            var ray = new RaycastInput()
            {
                Start = pos,
                End = pos + (direction * 0.9f),
                Filter = new CollisionFilter()
                {
                    GroupIndex = 0,
                    BelongsTo = 1u << 1,
                    CollidesWith = 1u << 2
                }
            };
            return pw.CastRay();
        }
    }
    /*/
    protected override void OnUpdate()
    {
        throw new System.NotImplementedException();
    }
}

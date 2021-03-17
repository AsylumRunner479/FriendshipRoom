using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using Unity.Physics;

public class MovementSystem : SystemBase
{
    protected override void OnUpdate()
    {
        
        Entities.ForEach((ref PhysicsVelocity physVel, in Movement mov) => {
            var step = mov.direction * mov.speed;
            physVel.Linear = step;
        }).Schedule();
    }
}

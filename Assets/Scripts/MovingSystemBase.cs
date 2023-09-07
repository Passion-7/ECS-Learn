using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public partial class MovingSystemBase : SystemBase {
    protected override void OnUpdate() {
        foreach (var transform in SystemAPI.Query<LocalTransform>()) {
            transform.Translate(new float3(SystemAPI.Time.DeltaTime));
        }
    }
}
using Unity.Entities;
using Unity.Mathematics;

namespace Svelto.ECS.MiniExamples.Example1B
{
    public struct UnityEcsEntityStruct : IEntityStruct, INeedEGID
    {
        public Entity        uecsEntity;
        public float3        spawnPosition;

        public EGID ID { get; set; }
    }
}
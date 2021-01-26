using Svelto.ECS;
using FixedMaths;

namespace MiniExamples.DeterministicPhysicDemo.Physics.EntityComponents
{
    // 圆形碰撞器组件
    public struct CircleColliderEntityComponent : IEntityComponent
    {
        public FixedPoint        Radius;
        public FixedPointVector2 Center;

        public CircleColliderEntityComponent(FixedPoint radius, FixedPointVector2 center)
        {
            Radius = radius;
            Center = center;
        }
    }
}
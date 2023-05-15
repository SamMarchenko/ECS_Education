using Entitas;

namespace Components
{
    [Game]
    public class MoveComponent : IComponent
    {
        public float directionX;
        public float speed;
    }
}
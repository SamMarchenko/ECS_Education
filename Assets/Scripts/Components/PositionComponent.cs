using Entitas;
using UnityEngine;

namespace Components
{
    [Game]
    public class PositionComponent : IComponent
    {
        public Vector2 value;
    }
}
using Entitas;
using UnityEngine;

namespace DefaultNamespace.Components
{
    [Game]
    public class PositionComponent : IComponent
    {
        public Vector2 value;
    }
}
using Entitas;
using UnityEngine;

namespace Components
{
    [Game]
    public class JumpComponent : IComponent
    {
        public Rigidbody2D Rigidbody;
        public float impulseValue;
    }
}
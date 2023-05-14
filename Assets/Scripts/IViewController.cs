using Entitas;
using UnityEngine;

namespace DefaultNamespace
{
    public interface IViewController
    {
        Rigidbody2D Rigidbody { get; }
        Vector2 Position { get; set; }
        bool Active { get; set; }
        void InitView(Contexts contexts, IEntity entity);
        void DestroyView();
    }
}
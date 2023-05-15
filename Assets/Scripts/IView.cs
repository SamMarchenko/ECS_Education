using UnityEngine;

public interface IView
{
    SpriteRenderer SpriteRenderer { get; }
    Transform Transform { get; }
    Vector2 Position { get; }
    Rigidbody2D Rigidbody { get; }
}
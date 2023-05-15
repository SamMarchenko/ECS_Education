using Components;
using UnityEngine;

public class PlayerView : MonoBehaviour, IView
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Transform _transform;
    [SerializeField] private Rigidbody2D _rigidbody;

    public SpriteRenderer SpriteRenderer => _spriteRenderer;
    public Transform Transform => _transform;
    public Vector2 Position => new Vector2(transform.position.x, transform.position.y);
    public Rigidbody2D Rigidbody => _rigidbody;
}
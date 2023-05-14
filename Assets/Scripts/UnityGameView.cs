using DefaultNamespace;
using Entitas;
using UnityEngine;

public class UnityGameView : MonoBehaviour, IViewController
{
    [SerializeField] private Rigidbody2D _rigidbody;
    
    private Contexts _contexts;
    private GameEntity _entity;
    public Rigidbody2D Rigidbody => _rigidbody;

    public Vector2 Position
    {
        get => new Vector2(transform.position.x, transform.position.y);
        set => transform.position = new Vector3(value.x, value.y, transform.position.z);
    }

    public bool Active
    {
        get => gameObject.activeSelf;
        set => gameObject.SetActive(value);
    }

    public void InitView(Contexts contexts, IEntity entity)
    {
        _entity = (GameEntity) entity;
        _contexts = contexts;
    }

    public void DestroyView()
    {
        Destroy(gameObject);
    }
}
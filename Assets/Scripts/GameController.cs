using Entitas;
using Services;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //временно
    [SerializeField] private PlayerView _playerPrefab;
    
    
    private Contexts _context;
    private Systems _systems;
    private AllServices _services;

    private void Start()
    {
        _services = new AllServices(new KeyBoardInputService());
        
        _context = Contexts.sharedInstance;

        _systems = new Feature()
            .Add(new CreatePlayerSystem(_context, _playerPrefab))
            .Add(new RegisterInputServiceSystem(_context, _services.Input))
            .Add(new UpdateInput(_context))
            .Add(new PlayerMoveSystem(_context.game))
            .Add(new PlayerJumpSystem(_context.game))
            .Add(new UpdatePositionSystem(_context))
            ;
            
        _systems.Initialize();
    }

    private void Update()
    {
        _systems.Execute();
        _systems.Cleanup();
    }
}
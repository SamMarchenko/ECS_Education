using Entitas;
using UnityEngine;

public class CreatePlayerSystem : IInitializeSystem
{
    private readonly Contexts _context;
    private readonly PlayerView _playerPrefab;

    public CreatePlayerSystem(Contexts context, PlayerView playerPrefab)
    {
        _context = context;
        _playerPrefab = playerPrefab;
    }

    public void Initialize()
    {
        var playerView = Object.Instantiate(_playerPrefab);
        
        var e = _context.game.CreateEntity();
        e.AddView(playerView);
        e.AddPosition(playerView.Position);
        e.AddMove(0f, 50f);
        e.AddJump(playerView.Rigidbody, 50f);
        e.AddInput(false, 0);
        e.isInputListener = true;
    }
}
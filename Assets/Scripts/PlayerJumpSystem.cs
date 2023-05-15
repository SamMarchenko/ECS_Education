using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class PlayerJumpSystem : ReactiveSystem<GameEntity>
{
    public PlayerJumpSystem(IContext<GameEntity> context) : base(context)
    {
    }

    public PlayerJumpSystem(ICollector<GameEntity> collector) : base(collector)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
        context.CreateCollector(GameMatcher.Input);

    protected override bool Filter(GameEntity entity) =>
        entity.hasInput && entity.hasJump;

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var e in entities)
        {
            if (e.input.isJumpPressed)
            {
                e.view.instance.Rigidbody.AddForce(Vector2.up * e.jump.impulseValue, ForceMode2D.Impulse);
                Debug.Log("Jumped");
            }
        }
    }
}
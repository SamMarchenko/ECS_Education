using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class PlayerMoveSystem : ReactiveSystem<GameEntity>
{
    private readonly IContext<GameEntity> _context;

    public PlayerMoveSystem(IContext<GameEntity> context) : base(context)
    {
        _context = context;
    }

    public PlayerMoveSystem(ICollector<GameEntity> collector) : base(collector)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
        context.CreateCollector(GameMatcher.Input);

    protected override bool Filter(GameEntity entity) =>
        entity.hasMove && entity.hasInput;

    protected override void Execute(List<GameEntity> entities)
    {//todo: переделать логику перемещения чтобы не залипали на стенах
        foreach (var e in entities)
        {
            var velocity = e.view.instance.Rigidbody.velocity;
            
            if (e.input.moveDirectionX != 0)
            {
                e.view.instance.Rigidbody.velocity = new Vector2(e.input.moveDirectionX * e.move.speed, velocity.y); 
                //e.view.instance.Rigidbody.velocity += new Vector2(e.input.moveDirectionX, 0) * e.move.speed * Time.deltaTime;
            }
            else
            {
                velocity = new Vector2(0f, velocity.y);
                e.view.instance.Rigidbody.velocity = velocity;
                return;
            }
        }
    }
}
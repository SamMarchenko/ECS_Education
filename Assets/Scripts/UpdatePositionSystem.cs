using Entitas;

public class UpdatePositionSystem :IExecuteSystem
{
    private readonly IGroup<GameEntity> _group;

    public UpdatePositionSystem(Contexts context)
    {
        _group = context.game.GetGroup(GameMatcher.AllOf(GameMatcher.View, GameMatcher.Position));
    }

    

    public void Execute()
    {
        foreach (var e in _group.GetEntities())
        {
            e.position.value = e.view.instance.Position;
        }
    }
}
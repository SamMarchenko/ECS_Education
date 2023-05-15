using Entitas;

public class UpdateInput : IExecuteSystem
{
    private readonly Contexts _context;
    private readonly IGroup<GameEntity> _inputListeners;
    private readonly IGroup<InputEntity> _input;


    public UpdateInput(Contexts context)
    {
        _context = context;
        _inputListeners = context.game.GetGroup(GameMatcher.AnyOf(GameMatcher.InputListener));
        _input = context.input.GetGroup(InputMatcher.AllOf(InputMatcher.InputService));
    }

    public void Execute()
    {
        if (_input.GetEntities().Length != 0)
        {
            var inputService = _input.GetEntities()[0].inputService.instance;
            foreach (var e in _inputListeners.GetEntities())
            {
                e.ReplaceInput(inputService.isJumpPressed, inputService.moveDirection);
            }
        }
    }
}
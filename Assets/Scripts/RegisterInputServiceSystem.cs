using Entitas;

public class RegisterInputServiceSystem : IInitializeSystem
{
    private readonly Contexts _context;
    private readonly IInputService _inputService;

    public RegisterInputServiceSystem(Contexts context, IInputService inputService)
    {
        _context = context;
        _inputService = inputService;
    }

    public void Initialize()
    {
        var e = _context.input.CreateEntity();
        e.ReplaceInputService(_inputService);
        e.ReplaceInput(false, 0f);
    }
}
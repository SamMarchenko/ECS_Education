using Entitas;
using Services;

public class RegisterViewServiceSystem : IInitializeSystem
{
    private readonly Contexts _contexts;
    private readonly IViewService _viewService;

    public RegisterViewServiceSystem(Contexts contexts, IViewService viewService)
    {
        _contexts = contexts;
        _viewService = viewService;
    }

    public void Initialize()
    {
        _contexts.game.ReplaceViewService(_viewService);
    }
}
﻿using DefaultNamespace;
using Entitas;
using Services;

public class RegisterInputServiceSystem : IInitializeSystem
{
    private readonly Contexts _contexts;
    private readonly IInputService _inputService;

    public RegisterInputServiceSystem(Contexts contexts, IInputService inputService)
    {
        _contexts = contexts;
        _inputService = inputService;
    }

    public void Initialize()
    {
        _contexts.game.ReplaceInputService(_inputService);
    }
}
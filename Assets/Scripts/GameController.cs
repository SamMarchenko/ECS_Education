using System;
using Entitas;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameController : MonoBehaviour
    {
        public GameSetup GameSetup;
        private Systems _systems;
        private void Start()
        {
            var contexts = Contexts.sharedInstance;

            var entity = contexts.game.CreateEntity();
            entity.AddGameSetup(GameSetup);
            
            _systems = CreateSystems(contexts);
            _systems.Initialize();
        }

        private Systems CreateSystems(Contexts contexts)
        {
            return new Feature("Game")
                .Add(new HelloWorldSystem())
                .Add(new InitializePlayerSystem(contexts));
        }

        private void Update()
        {
            
        }
    }
}
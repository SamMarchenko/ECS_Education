using Entitas;

namespace DefaultNamespace
{
    public class InitializePlayerSystem: IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitializePlayerSystem(Contexts contexts)
        {
            _contexts = contexts;
        }
        
        public void Initialize()
        {
            var entity = _contexts.game.CreateEntity();
            entity.isPlayer = true;
            entity.AddResource(_contexts.game.gameSetup.value.Player);
        }
    }
}
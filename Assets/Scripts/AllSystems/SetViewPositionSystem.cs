using System.Collections.Generic;
using Entitas;

namespace AllSystems
{
    public class SetViewPositionSystem : ReactiveSystem<GameEntity>
    {
        public SetViewPositionSystem(Contexts context) : base(context.game)
        {
        }
        
        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.Position);

        protected override bool Filter(GameEntity entity) =>
            entity.hasPosition && entity.hasView;

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                e.view.instance.Position = e.position.value;
            }
        }

       
    }
}
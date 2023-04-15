using System;
using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace DefaultNamespace
{
    public class InstantiateViewSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _context;

        public InstantiateViewSystem(Contexts context) : base(context.game)
        {
            _context = context;
        }

        public InstantiateViewSystem(ICollector<GameEntity> collector) : base(collector)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Resource);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasResource;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                var gameObject = MonoBehaviour.Instantiate(entity.resource.Prefab);
                entity.AddView(gameObject);
                //gameObject.Link(entity, _context.game);
            }
        }
    }
}
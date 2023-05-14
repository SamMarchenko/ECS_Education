using System.Collections.Generic;
using Entitas;
using Services;

namespace AllSystems
{
    public class LoadAssetSystem : ReactiveSystem<GameEntity>, IInitializeSystem
    {
        private readonly Contexts _context;
        private IViewService _viewService;

        public void Initialize()
        {
            _viewService = _context.game.viewService.instance;
        }

        public LoadAssetSystem(Contexts context) : base(context.game)
        {
            _context = context;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.Asset);

        protected override bool Filter(GameEntity entity) =>
            entity.hasAsset && !entity.hasView;

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                var view = _viewService.LoadAsset(_context, e, e.asset.name);
                if (view != null)
                    e.ReplaceView(view);
            }
        }
    }
}
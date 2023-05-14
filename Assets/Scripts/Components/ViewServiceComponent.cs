using Entitas;
using Entitas.CodeGeneration.Attributes;
using Services;

namespace DefaultNamespace.Components
{
    [Game, Unique]
    public class ViewServiceComponent : IComponent
    {
        public IViewService instance;
    }
}
using Entitas;

namespace Components
{
    [Game]
    public class ViewComponent : IComponent
    {
        public IView instance;
    }
}
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Components
{
    [Input, Unique]
    public class InputServiceComponent : IComponent
    {
        public IInputService instance;
    }
}
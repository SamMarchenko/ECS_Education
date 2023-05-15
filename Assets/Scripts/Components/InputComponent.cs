using Entitas;

namespace Components
{
    [Input, Game]
    public class InputComponent : IComponent
    {
        public bool isJumpPressed;
        public float moveDirectionX;
    }
}
namespace Services
{
    public interface IInputService
    {
        float MoveDirectionX { get; }
        bool JumpButtonPressed { get; }
    }
}
namespace Services
{
    public class AllServices
    {
        public readonly IInputService Input;

        public AllServices(IInputService input)
        {
            Input = input;
        }
    }
}
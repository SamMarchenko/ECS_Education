namespace Services
{
    public class Services
    {
        public readonly IInputService Input;
        public readonly IViewService View;

        public Services(IInputService input, IViewService view)
        {
            Input = input;
            View = view;
        }
    }
}
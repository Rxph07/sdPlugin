namespace sdPlugin.Input
{
    public class ButtonInput : BaseInput
    {
        private readonly System.Action _onClick;

        public ButtonInput(string name, System.Action onClick) : base(name)
        {
            _onClick = onClick;
        }

        public void OnClick()
        {
            _onClick();
        }
    }
}

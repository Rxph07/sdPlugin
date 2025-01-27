namespace sdPlugin.Input
{
    public abstract class ButtonInput : BaseInput
    {
        public ButtonInput(string name) : base(name)
        {
        }

        public abstract void OnClick();
    }
}

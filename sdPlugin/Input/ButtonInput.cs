namespace sdPlugin.Input
{
    public abstract class ButtonInput : BaseInput
    {
        public ButtonInput(string name, Plugin plugin) : base(name)
        {
            Plugin = plugin;
        }

        public abstract void OnClick();
    }
}

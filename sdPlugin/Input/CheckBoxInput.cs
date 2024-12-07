namespace sdPlugin.Input
{
    public class CheckBoxInput : BaseInput
    {
        public bool Value { get; set; }

        public CheckBoxInput(string name, bool value) : base(name)
        {
            Value = value;
        }
    }
}

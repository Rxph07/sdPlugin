namespace sdPlugin.Input
{
    public class TextInput : BaseInput
    {
        public string Value { get; set; }

        public TextInput(string name, string value) : base(name)
        {
            Value = value;
        }
    }
}

namespace sdPlugin.Input
{
    public class NumberInput : BaseInput
    {
        public int Value { get; set; }

        public NumberInput(string name, int value) : base(name)
        {
            Value = value;
        }
    }
}

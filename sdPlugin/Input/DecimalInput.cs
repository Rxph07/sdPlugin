namespace sdPlugin.Input
{
    public class DecimalInput : BaseInput
    {
        public double Value { get; set; }

        public DecimalInput(string name, double value) : base(name)
        {
            Value = value;
        }
    }
}

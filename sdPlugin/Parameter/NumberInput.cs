namespace sdPlugin.Parameter
{
    public class NumberInput : Parameter
    {
        public long Value { get; set; }
        public long Min { get; set; }
        public long Max { get; set; }

        public NumberInput(string name, long value, long min, long max) : base(name)
        {
            Value = value;
            Min = min;
            Max = max;
        }
    }
}

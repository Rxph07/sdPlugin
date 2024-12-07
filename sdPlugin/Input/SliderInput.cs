namespace sdPlugin.Input
{
    public class SliderInput : BaseInput
    {
        public int Value { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public int Step { get; set; }

        public SliderInput(string name, int value, int min, int max, int step = 1) : base(name)
        {
            if (max <= min)
                max = min + 1;

            if (step <= 1) step = 1;

            if (Value < min)
                Value = min;
            else if (Value > max)
                Value = max;
            else
                Value = value;

            Max = max;
            Min = min;
            Step = step;
        }
    }
}

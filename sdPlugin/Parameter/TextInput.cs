﻿namespace sdPlugin.Parameter
{
    public class TextInput : Parameter
    {
        public string Value { get; set; }

        public TextInput(string name, string value) : base(name)
        {
            Value = value;
        }
    }
}

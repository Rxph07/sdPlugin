using System.Collections.Generic;

namespace sdPlugin.Parameter
{
    public class BaseInput
    {
        public string Name { get; set; }

        protected BaseInput(string name)
        {
            Name = name;
        }

        public BaseInput Clone()
        {
            return (BaseInput)this.MemberwiseClone();
        }

        public static bool Get<T>(Dictionary<string, BaseInput> parameters, string key, out T value)
        {
            if (parameters.TryGetValue(key, out var parameterValue) && parameterValue is T typedValue)
            {
                value = typedValue;
                return true;
            }

            value = default;
            return false;
        }
    }
}

using System.Collections.Generic;

namespace sdPlugin.Parameter
{
    public class Parameter
    {
        public string Name { get; set; }

        protected Parameter(string name)
        {
            Name = name;
        }

        public static bool Get<T>(Dictionary<string, Parameter> parameters, string key, out T value)
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

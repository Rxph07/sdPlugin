using System.Collections.Generic;
using System.Linq;

namespace sdPlugin.Input
{
    public class BaseInput
    {
        public string Name { get; set; }
        public Plugin Plugin { get; set; }

        protected BaseInput(string name)
        {
            Name = name;
        }

        public BaseInput Clone()
        {
            return (BaseInput)this.MemberwiseClone();
        }

        public static T GetOrDefault<T>(Dictionary<string, BaseInput> parameters, List<BaseInput> defaults, string key) where T : BaseInput
        {
            return parameters.TryGetValue(key, out var parameterValue) && parameterValue is T typedValue
                ? typedValue
                : defaults.FirstOrDefault(input => input.Name == key) as T;
        }
    }
}

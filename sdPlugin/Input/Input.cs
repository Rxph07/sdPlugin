using System.Collections.Generic;
using System.Linq;

namespace sdPlugin.Input
{
    public class Input
    {
        public static Dictionary<string, BaseInput> ConvertToDictionary(List<BaseInput> inputs)
        {
            try
            {
                return inputs.ToDictionary(input => input.Name);
            }
            catch { return null; }
        }
    }
}

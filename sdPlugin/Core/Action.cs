using System.Collections.Generic;

namespace sdPlugin
{
    public abstract class Action
    {
        public abstract string Name { get; }
        public abstract string Icon { get; }
        public virtual string Tooltip { get; }
        public virtual Dictionary<string, Parameter.Parameter> Parameters { get; }
        public virtual void OnKeyDown(Dictionary<string, Parameter.Parameter> parameters) { }
        public virtual void OnKeyUp(Dictionary<string, Parameter.Parameter> parameters) { }
        public virtual void OnAppear(Dictionary<string, Parameter.Parameter> parameters) { }
        public virtual void OnDisappear(Dictionary<string, Parameter.Parameter> parameters) { }
    }
}

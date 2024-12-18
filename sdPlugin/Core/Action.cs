using System.Collections.Generic;

namespace sdPlugin
{
    public abstract class Action
    {
        public abstract string Name { get; }
        public abstract string Icon { get; }
        public virtual string Tooltip { get; }
        public virtual Dictionary<string, Input.BaseInput> Inputs { get; }
        public virtual void OnInit(Dictionary<string, Input.BaseInput> inputs) { }
        public virtual void OnEdit(Dictionary<string, Input.BaseInput> inputs) { }
        public virtual void OnKeyDown(Dictionary<string, Input.BaseInput> inputs) { }
        public virtual void OnAppear(Dictionary<string, Input.BaseInput> inputs) { }
        public virtual void OnDisappear(Dictionary<string, Input.BaseInput> inputs) { }
    }
}

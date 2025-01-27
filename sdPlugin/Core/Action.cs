using System.Collections.Generic;

namespace sdPlugin
{
    public abstract class Action
    {
        public abstract string Name { get; }
        public abstract string Icon { get; }
        public virtual string Tooltip { get; }
        public virtual Dictionary<string, Input.BaseInput> Inputs { get; }
        public Plugin Plugin { get; set; }
        public virtual void OnEdit(Dictionary<string, Input.BaseInput> inputs) { }
        public virtual void OnEditSaved(Dictionary<string, Input.BaseInput> inputs) { }
        public virtual void OnEditCanceled(Dictionary<string, Input.BaseInput> inputs) { }
        public virtual void OnKeyDown(Dictionary<string, Input.BaseInput> inputs) { }
        public virtual void OnAppear(Dictionary<string, Input.BaseInput> inputs) { }
        public virtual void OnDisappear(Dictionary<string, Input.BaseInput> inputs) { }

        public Action(Plugin plugin)
        {
            Plugin = plugin;
        }
    }
}

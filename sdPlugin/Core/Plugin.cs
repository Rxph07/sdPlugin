using System.Collections.Generic;

namespace sdPlugin
{
    public abstract class Plugin
    {
        public abstract string UUID { get; }
        public abstract string CategoryName { get; }
        public abstract string CategoryIcon { get; }
        public abstract string Version { get; }
        public abstract string Author { get; }
        public virtual string Description => "";
        public virtual void Initialize() { }
        public abstract List<sdPlugin.Action> GetActions();
    }
}

using sdPlugin.Core;
using System;
using System.Collections.Generic;
using System.IO;

namespace sdPlugin
{
    public abstract class Plugin
    {
        public abstract string UUID { get; }
        public abstract string CategoryName { get; }
        public abstract string CategoryIcon { get; }
        public abstract string Version { get; }
        public abstract string Author { get; }
        public PluginConfig Config { get; }
        public virtual void Initialize() { }
        public abstract List<sdPlugin.Action> GetActions();

        protected Plugin()
        {
            string pluginPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins", UUID);
            Config = new PluginConfig(pluginPath);
        }
    }
}

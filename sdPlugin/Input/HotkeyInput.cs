using System.Collections.Generic;
using WindowsInput.Native;

namespace sdPlugin.Input
{
    public class HotkeyInput : BaseInput
    {
        public List<VirtualKeyCode> Modifiers { get; set; } = new List<VirtualKeyCode>();
        public VirtualKeyCode Key { get; set; } = 0;
        public HotkeyInput(string name) : base(name)
        {
        }
    }
}

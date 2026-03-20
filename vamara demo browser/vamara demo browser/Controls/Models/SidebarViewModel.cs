using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vamara_demo_browser.Controls.Models;

public enum SidebarDockPosition { Right, Left, Floating }

public sealed class SidebarState
{
    public bool IsOpen { get; set; }
    public SidebarDockPosition Position { get; set; }
    public double Width { get; set; } = 320;
}

internal class SidebarViewModel
{
}

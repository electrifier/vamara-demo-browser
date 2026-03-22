using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vamara_demo_browser.Controls.Models;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class ShellFolderModel
{
    string _name;
    string _description;
    // Bitmap _icon;
    object _attributes;

    internal ShellFolderModel(string name, string description, object attributes)
    {
        _name = name;
        _description = description;
        _attributes = attributes;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

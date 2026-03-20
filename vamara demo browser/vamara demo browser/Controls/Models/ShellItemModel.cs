using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vamara_demo_browser.Controls.Models;

internal class ShellItemModel
{
    string _name;
    string _description;
    // Bitmap _icon;
    object _attributes;

    internal ShellItemModel(string name, string description, object attributes)
    {
        _name = name;
        _description = description;
        _attributes = attributes;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vamara_demo_browser.Controls.Models;

internal class ShellFolderModel
{
    string _name;
    string _description;
    StorageItemTypes _type;
    // Bitmap _icon;
    object _attributes;

    internal ShellFolderModel(string name, string description, StorageItemTypes type, object attributes)
    {
        _name = name;
        _description = description;
        _type = type;
        _attributes = attributes;
    }
}

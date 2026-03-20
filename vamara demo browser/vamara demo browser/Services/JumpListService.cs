using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vamara_demo_browser.Services;

internal class JumpListService
{

}

internal class JumpListItem
{

}
internal class JumpListSection
{

}
internal class JumpListAction
{

}

internal interface IJumpListService 
{
    IEnumerable<JumpListItem> GetJumpListItems();
}

using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace vamara_demo_browser.Services;


/// <summary>
/// 
/// - Assembly Scanning, filter libs, get versions, etc.
/// - Version Info, `AssemblyInformationalVersion`
/// - GIT Info incl. Commit Hash, Branch, etc.
/// </summary>
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public partial class AppInfoService
{
    public AppInfoService()
    {
    }

    public IEnumerable<AssemblyName> GetVanaraAssemblies()
    {
        return Assembly
            .GetExecutingAssembly()
            .GetReferencedAssemblies()
            .Where(a => a.Name.StartsWith("Vanara"));
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

/*  public abstract class AppService
{
    // optional: Logging, DI-Hooks, Config-Access
}*/

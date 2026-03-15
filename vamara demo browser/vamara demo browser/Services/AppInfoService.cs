using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace vamara_demo_browser.Services;


/// <summary>
/// 
/// - Assembly Scanning, filter libs, get versions, etc.
/// - Version Info, `AssemblyInformationalVersion`
/// - GIT Info incl. Commit Hash, Branch, etc.
/// </summary>
partial class AppInfoService
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
}

/*  public abstract class AppService
{
    // optional: Logging, DI-Hooks, Config-Access
}*/

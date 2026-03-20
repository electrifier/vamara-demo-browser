using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace vamara_demo_browser.Services;


/// <summary>
/// 
/// - Assembly Scanning, filter libs, get versions, etc.
/// - Version Info, `AssemblyInformationalVersion`
/// - GIT Info incl. Commit Hash, Branch, etc.
/// </summary>
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(), nq}}")]
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

    internal string? GetAppVersion()
    {
        throw new NotImplementedException();
    }

    internal string? GetBuildInfo()
    {
        return new StringBuilder().AppendLine("{this}").Append("TODO: Build Info").ToString();
    }


    private string GetDebuggerDisplay()
    {
        return new StringBuilder().AppendLine("{this}").Append(GetDebuggerDisplay()).ToString();
    }
}

/*  public abstract class AppService
{
    // optional: Logging, DI-Hooks, Config-Access
}*/

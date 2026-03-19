using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using vamara_demo_browser.Services;

namespace vamara_demo_browser.Models;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]

public class AboutPageViewModel
{
    public string AppVersion { get; }
    public string BuildInfo { get; }
//    public ObservableCollection<VanaraAssemblyInfo> VanaraAssemblies { get; }
    public string MeditationText { get; }

    public AboutPageViewModel(AppInfoService appInfo)
    {
        AppVersion = appInfo.GetAppVersion();
        BuildInfo = appInfo.GetBuildInfo();
//        VanaraAssemblies = new ObservableCollection<VanaraAssemblyInfo>(appInfo.GetVanaraAssemblies());
        MeditationText = VanaraMeditation.GetRandom();
    }

    private string GetDebuggerDisplay()
    {
        return new StringBuilder().AppendLine("{this}").Append(GetDebuggerDisplay()).ToString();
    }
}

public class VanaraAssemblyInfo
{
    private string GetDebuggerDisplay()
    {
        return new StringBuilder().AppendLine("{this}").Append(GetDebuggerDisplay()).ToString();
    }
}

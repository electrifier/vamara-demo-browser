using System.Collections.ObjectModel;
using vamara_demo_browser.Services;

public class AboutPageViewModel
{
    public string AppVersion { get; }
    public string BuildInfo { get; }
//    public ObservableCollection<VanaraAssemblyInfo> VanaraAssemblies { get; }
    public string MeditationText { get; }

    public AboutPageViewModel(AppInfoService appInfo)
    {
//        AppVersion = appInfo.GetAppVersion();
//        BuildInfo = appInfo.GetBuildInfo();
//        VanaraAssemblies = new ObservableCollection<VanaraAssemblyInfo>(appInfo.GetVanaraAssemblies());
//        MeditationText = VanaraMeditation.GetRandom();
    }
}

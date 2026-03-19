using Microsoft.UI.Xaml;

namespace vamara_demo_browser;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// 
/// <b>Quote:</b> <i>To learn more about WinUI, the WinUI project structure, and more about
/// our project templates, see: http://aka.ms/winui-project-info.</i>
/// </summary>
public partial class App : Application
{
    private Window? _window;
    public static Window MainWindow => ((App)Current)._window!;

    /// <summary>
    /// Initializes the singleton application object.  This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Invoked when the application is launched.
    /// </summary>
    /// <param name="args">Details about the launch request and process.</param>
    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        _window = new MainWindow();
        _window.Activate();
    }
}

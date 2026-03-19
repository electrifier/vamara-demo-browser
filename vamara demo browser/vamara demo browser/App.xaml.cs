using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using System;
using System.Diagnostics;
using vamara_demo_browser.Models;
using vamara_demo_browser.Services;
using static Vanara.PInvoke.Ole32.PROPERTYKEY.System;

namespace vamara_demo_browser;

/// <summary>Provides application-specific behavior to supplement the default Application class.
/// <b>Quote:</b> <i>To learn more about WinUI, the WinUI project structure, and more about
/// our project templates, see: http://aka.ms/winui-project-info.</i></summary>
public partial class App : Application
{
    public ServiceCollection ServiceCollection = new();
    public static IServiceProvider Services { get; private set; }

    private Window? _window;
    public static Window MainWindow => ((App)Current)._window!;

    /// <summary>Initializes the singleton application object. This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().</summary>
    public App()
    {
        Debug.WriteLine("App.ctor()");
        InitializeComponent();
        ConfigureServices();
    }

    private void ConfigureServices()
    {
        try 
        {
            // Services
            ServiceCollection.AddSingleton<ILocalizationService, LocalizationService>();

            // ViewModels
            ServiceCollection.AddTransient<SettingsViewModel>();

            // Build the service provider
            Services = ServiceCollection.BuildServiceProvider();
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"App.ConfigureServices(): Error configuring services: {ex}");
            throw;
        }
    }

    /// <summary>Invoked when the application is launched.</summary>
    /// <param name="args">Details about the launch request and process.</param>
    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        try
        {
            _window = new MainWindow();
            _window.Activate();
        }
        catch (Exception)
        {
            throw;
        }
    }
}

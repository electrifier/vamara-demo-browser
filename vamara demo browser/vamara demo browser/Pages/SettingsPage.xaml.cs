using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using vamara_demo_browser.Models;

namespace vamara_demo_browser.Pages;

public sealed partial class SettingsPage : Page
{
    public SettingsViewModel ViewModel { get; }

    public SettingsPage()
    {
//        this.InitializeComponent();

        ViewModel = App.Services.GetRequiredService<SettingsViewModel>();

        //ViewModel = App.Services.GetRequiredService<SettingsViewModel>();

    }
}

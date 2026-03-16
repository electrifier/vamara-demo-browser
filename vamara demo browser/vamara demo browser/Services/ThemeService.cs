using Microsoft.UI.Xaml;
using System;
using System.Diagnostics;

namespace vamara_demo_browser.Services;

public interface IThemeService
{
    ElementTheme CurrentTheme { get; }
    void SetTheme(ElementTheme theme);
}

public class ThemeService : IThemeService
{
    private const string Key = "AppTheme";

    public ElementTheme CurrentTheme => throw new NotImplementedException();

    public void SetTheme(ElementTheme theme)
    {
        Debug.WriteLine($"SetTheme called with {theme}");
    }

    //    public ElementTheme CurrentTheme =>
    //        (ElementTheme)(ApplicationData.Current.LocalSettings.Values[Key] ?? (int)ElementTheme.Default);
    //
    //    public void SetTheme(ElementTheme theme)
    //    {
    //        ApplicationData.Current.LocalSettings.Values[Key] = (int)theme;
    //        if (App.MainWindow.Content is FrameworkElement root)
    //            root.RequestedTheme = theme;
    //    }
}

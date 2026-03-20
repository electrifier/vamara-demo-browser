using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml;
using System.Collections.Generic;
using vamara_demo_browser.Services;

namespace vamara_demo_browser.Models;

public sealed partial class SettingsViewModel : ObservableObject
{
    private readonly IReadOnlyList<string> languages = ["en-US", "de-DE"];      // TODO: Get languages from localization service
    private readonly ILocalizationService _localizationService;
    private string _selectedLanguage;
    private readonly IThemeService _themeService;

//    private readonly IReadOnlyList<Windows.UI.Xaml.ElementTheme> themes = [ElementTheme.Default, ElementTheme.Light, ElementTheme.Dark];

    public IReadOnlyList<ElementTheme> Themes { get; } =
        [ElementTheme.Default, ElementTheme.Light, ElementTheme.Dark];

    public string SelectedLanguage
    {
        get => _selectedLanguage;
        set
        {
            if (SetProperty(ref _selectedLanguage, value))
                _localizationService.SetLanguage(value);
        }
    }

    private ElementTheme _selectedTheme;
    public ElementTheme SelectedTheme
    {
        get => _selectedTheme;
        set
        {
            if (SetProperty(ref _selectedTheme, value))
                _themeService.SetTheme(value);
        }
    }

    public SettingsViewModel(IThemeService themeService, ILocalizationService localizationService)
    {
        _themeService = themeService;
        _selectedTheme = themeService.CurrentTheme;
        _localizationService = localizationService;
        // _selectedLanguage = _localizationService.CurrentLanguage;
        _selectedLanguage = "en-US";    // TODO: Get current language from localization service
    }

    public IReadOnlyList<string> GetLanguages()
    {
        // TODO: Get languages from localization service
        return languages;
    }
}

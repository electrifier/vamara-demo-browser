using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vamara_demo_browser.Services;

namespace vamara_demo_browser.Models;

public class SettingsViewModel : ObservableObject
{
    private readonly IThemeService _themeService;
    private readonly ILocalizationService _localizationService;

    public IReadOnlyList<string> Languages { get; } =
        new[] { "en-US", "de-DE" };
    
    public IReadOnlyList<ElementTheme> Themes { get; } =
        new[] { ElementTheme.Default, ElementTheme.Light, ElementTheme.Dark };

    private string _selectedLanguage;
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

    public SettingsViewModel(IThemeService themeService)
    {
        _themeService = themeService;
        _selectedTheme = themeService.CurrentTheme;
        _localizationService = _localizationService;
        _selectedLanguage = _localizationService.CurrentLanguage;
    }

}

using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vamara_demo_browser.Models;
using vamara_demo_browser.Pages;
using Windows.Globalization;

namespace vamara_demo_browser.Services;


public class LocalizationService : ILocalizationService
{
    private readonly IReadOnlyList<string> _languages =
        new[] { "en-US", "de-DE" };

    public event EventHandler LanguageChanged;

    public IReadOnlyList<string> AvailableLanguages => _languages;

    public string CurrentLanguage =>
        ApplicationLanguages.PrimaryLanguageOverride
        ?? ApplicationLanguages.Languages.FirstOrDefault()
        ?? "en-US";

    public LocalizationService()
    {
        //        CurrentLanguage = Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride
        //                          ?? Windows.Globalization.ApplicationLanguages.Languages.First();
    }

    public void SetLanguage(string languageTag)
    {
        if (!_languages.Contains(languageTag))
            return;

        ApplicationLanguages.PrimaryLanguageOverride = languageTag;

        // Reload UI
        if (App.MainWindow.Content is FrameworkElement root)
        {
            var newRoot = new AboutPage();
            App.MainWindow.Content = newRoot;
        }
    }

    /*  public void SetLanguage(string languageCode) {
        if (languageCode == CurrentLanguage)
            return;
        if (!_languages.Contains(languageTag))
            return;

        Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = languageCode;
        CurrentLanguage = languageCode;

            // UI neu laden
        if (App.MainWindow.Content is FrameworkElement root)
        {
            var newRoot = new AboutPage();
            App.MainWindow.Content = newRoot;
        }

        LanguageChanged?.Invoke(this, EventArgs.Empty);
        } */
}

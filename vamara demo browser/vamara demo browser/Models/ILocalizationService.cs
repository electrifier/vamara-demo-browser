using System;
using System.Collections.Generic;

namespace vamara_demo_browser.Models;

public interface ILocalizationService
{
    string CurrentLanguage { get; }
    IReadOnlyList<string> AvailableLanguages { get; }

    void SetLanguage(string languageTag);

    event EventHandler LanguageChanged;
}

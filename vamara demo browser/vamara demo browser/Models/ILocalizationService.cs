using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vamara_demo_browser.Models;

public interface ILocalizationService
{
    string CurrentLanguage { get; }
    IReadOnlyList<string> AvailableLanguages { get; }

    void SetLanguage(string languageTag);
}

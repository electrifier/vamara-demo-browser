using System;

namespace vamara_demo_browser.Models;

public static class VanaraMeditation
{
    private static readonly string[] Lines =
    {
        "In der Tiefe der Windows-APIs liegt Klarheit. Vanara bringt sie ans Licht.",
        "Zwischen Handles und HRESULTs findet sich eine stille Eleganz.",
        "Wer die Win32-Welt versteht, versteht das Fundament moderner Software.",
        "Vanara ist die Brücke zwischen Vergangenheit und Zukunft des Windows-Stacks."
    };

    public static string GetRandom()
        => Lines[new Random().Next(Lines.Length)];
}

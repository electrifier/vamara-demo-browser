using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace vamara_demo_browser.Models;

/// <summary>
/// Vanara specific <inheritdoc cref="Exception"/>.
/// </summary>
internal class VanaraMeditation : Exception
{
    public VanaraMeditation() : base("Vanara Meditation: An unknown error occurred.")
    {
    }
    public VanaraMeditation(string message, Exception innerException) : base($"Vanara Meditation: {message}", innerException)
    {
    }
    public VanaraMeditation(string message, Exception innerException, CancellationToken cancellationToken) : base($"Vanara Meditation: {message}", innerException)
    {
        cancellationToken.ThrowIfCancellationRequested();
    }
    public VanaraMeditation(Exception message) : base($"Vanara Meditation: {message}")
    {
    }
    public VanaraMeditation(string message) : base($"Vanara Meditation: {message}")
    {
    }
    //public VanaraMeditation(COMValue) : base($"Vanara COMValue Meditation: {COMValue}")
}

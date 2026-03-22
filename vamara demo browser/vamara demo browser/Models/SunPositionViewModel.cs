using CommunityToolkit.Mvvm.ComponentModel;
using vamara_demo_browser.Services;

namespace vamara_demo_browser.Models;

public sealed partial class SunPositionViewModel : ObservableObject
{
    private readonly SunPositionProvider _provider;

    // TODO:    //[ObservableProperty]
    // TODO:    //private SunPosition _sun;

    public SunPositionViewModel(SunPositionProvider provider)
    {
        _provider = provider;
        UpdateSun();
    }

    private void UpdateSun()
    {
//        Sun = _provider.GetCurrent(49.8913, 10.8864); // Bamberg, BY, Germany
    }
}

using SunCalcNet;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using vamara_demo_browser.Interop;

namespace vamara_demo_browser.Services;

public sealed class SunPositionService
{
    public SunPosition GetSunPosition(DateTimeOffset timestamp, double latitude, double longitude)
    {
        var result = SunCalc.GetSunPosition(timestamp.UtcDateTime, latitude, longitude);

        return new SunPosition
        {
            Timestamp = timestamp,
            Latitude = latitude,
            Longitude = longitude,
            Azimuth = result.Azimuth * (180 / Math.PI),     // rad → grad
            Elevation = result.Altitude * (180 / Math.PI)   // rad → grad
        };
    }
}

public sealed class SunPositionProvider
{
    private readonly SunPositionService _service;

    public SunPositionProvider(SunPositionService service)
    {
        _service = service;
    }

    public SunPosition GetCurrent(double latitude, double longitude)
    {
        return _service.GetSunPosition(DateTimeOffset.Now, latitude, longitude);
    }
}

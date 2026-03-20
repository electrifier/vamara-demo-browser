using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vamara_demo_browser.Interop;

public sealed class SunPosition
{
    
    public DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// Latitude and Longitude of the observer's location on Earth, 
    /// which are essential for calculating the Sun's position in the sky.
    /// 
    /// Latitude is measured in degrees, where -90° represents the South Pole, 0° represents the Equator, 
    /// and 90° represents the North Pole. Longitude is also measured in degrees, where -180° represents 
    /// the westernmost point, 0° represents the Prime Meridian, and 180° represents the easternmost point. 
    /// 
    /// These coordinates allow us to determine the Sun's azimuth (the compass direction) and
    /// elevation (the angle above the horizon) at a specific time and location.
    /// </summary>
    public double Latitude { get; init; }       // degress, -90° = South Pole, 0° = Equator, 90° = North Pole
    public double Longitude { get; init; }      // degress, -180° = West, 0° = Prime Meridian, 180° = East

    public double Azimuth { get; init; }      // degress, 0° = North, 90° = East, 180° = South, 270° = West
    public double Elevation { get; init; }    // degress, 0° = horizon, 90° = zenith
}

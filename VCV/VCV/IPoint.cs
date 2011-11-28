using System;

namespace VCV
{
    public interface IPoint
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
        double Altitude { get; set; }
    }
}

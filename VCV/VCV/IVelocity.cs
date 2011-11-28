using System;

namespace VCV
{
    public interface IVelocity
    {
        /// <summary>
        /// http://en.wikipedia.org/wiki/Bearing_(navigation)
        /// </summary>
        Double Bearing { get; set; }
        /// <summary>
        /// Metres per second
        /// </summary>
        double Speed { get; set; }
    }
}

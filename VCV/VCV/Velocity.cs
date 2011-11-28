using System;

namespace VCV
{
    public class Velocity : IVelocity
    {
        #region IDirection Members

        public double Bearing { get; set; }
        public double Speed { get; set; }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bearing">In Degrees</param>
        /// <param name="Speed"></param>
        public Velocity(Double Bearing, Double Speed)
        {
            if (Bearing < 0.0 | Bearing > 359.9)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.Bearing = Bearing;
            this.Speed = Speed;
        }
    }
}

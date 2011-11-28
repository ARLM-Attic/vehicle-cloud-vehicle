using System;

namespace VCV
{
    [Serializable]
    public class Point : IPoint
    {
        public enum CardinalPoints { N, E, W, S, NE, NW, SE, SW }
        private const double RADIUS = 6376.5;
        private double latitude, longitude;

        #region IPoint Members

        /// <summary>
        /// Latitude in degrees. -90 to 90
        /// </summary>
        public Double Latitude
        {
            get { return latitude; }
            set
            {
                if (value > 90) throw new ArgumentOutOfRangeException("value", "Latitude value cannot be greater than 90.");
                if (value < -90) throw new ArgumentOutOfRangeException("value", "Latitude value cannot be less than -90.");
                latitude = value;
            }
        }

        /// <summary>
        /// Longitude in degree. -180 to 180
        /// </summary>
        public Double Longitude
        {
            get { return longitude; }
            set
            {
                if (value > 180) throw new ArgumentOutOfRangeException("value", "Longitude value cannot be greater than 180.");
                if (value < -180) throw new ArgumentOutOfRangeException("value", "Longitude value cannot be less than -180.");
                longitude = value;
            }
        }

        public double Altitude
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        /// <summary>
        /// Get distance in metres between this point and another point.
        /// </summary>
        /// <param name="Point"></param>
        /// <returns></returns>
        public Double GetDistance(IPoint Point)
        {
            Helper.LatLong Point1 = new Helper.LatLong(this.Latitude, this.Longitude);
            Helper.LatLong Point2 = new Helper.LatLong(Point.Latitude, Point.Longitude);
            return Helper.SphereSurfaceDistance(RADIUS, Point1, Point2);
        }

        /// <summary>
        /// Get bearing from this point to point.
        /// </summary>
        /// <param name="Point"></param>
        /// <returns>A double value in degrees.  From 0 to 360.</returns>
        public Double Bearing(IPoint Point)
        {
            Double latitude1 = this.Latitude.ToRadian();
            Double latitude2 = Point.Latitude.ToRadian();

            Double longitudeDifference = (Point.Longitude - this.Longitude).ToRadian();

            var y = Math.Sin(longitudeDifference) * Math.Cos(latitude2);
            var x = Math.Cos(latitude1) * Math.Sin(latitude2) - Math.Sin(latitude1) * Math.Cos(latitude2) * Math.Cos(longitudeDifference);

            return (Math.Atan2(y, x).ToDegree() + 360) % 360;
        }
    }
}

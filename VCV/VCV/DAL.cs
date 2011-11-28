using System;
using System.Collections.Generic;

namespace VCV
{
    public class DAL
    {
        public List<IObject> Add(Guid Id, IPoint Current, DateTime DeviceTime)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Staleness"></param>
        /// <param name="Radius">In metres</param>
        /// <returns></returns>
        public List<IObject> GetNearObjects(TimeSpan Staleness, Double Radius)
        {
            if (Radius <= 1000)
            {
                List<IObject> Objects = new List<IObject>();

                IPoint Pos1 = new Point() { Latitude = -27.47278, Longitude = 153.02532 };
                IVelocity Heading = new Velocity(20.0, 10.0);
                Heading.Bearing = 0.0;

                Guid Id = new Guid();
                Id = Guid.NewGuid();
                IObject Car1 = new Vehicle(Id, Pos1, null, System.DateTime.Now);

                Objects.Add(Car1);
                return Objects;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Radius less than 1000m");
            }
        }
    }
}

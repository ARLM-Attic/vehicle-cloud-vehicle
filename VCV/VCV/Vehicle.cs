using System;

namespace VCV
{
    [Serializable()]
    public class Vehicle : IObject
    {
        #region IObject Members

        public Guid Id { get; private set; }
        public IPoint Current { get; set; }
        public IVelocity Heading { get; set; }
        public DateTime LogDate { get; set; }
        public TimeSpan Staleness { get; set; }

        #endregion

        public Vehicle()
        {
            this.Id = new Guid();
            this.Id = Guid.NewGuid();
            LogDate = System.DateTime.Now;
        }

        public Vehicle(Guid Id, IPoint Current, IVelocity Heading, DateTime LogDate)
        {
            this.Id = Id;
            this.Current = Current;
            this.Heading = Heading;
            this.LogDate = LogDate;
        }
    }
}

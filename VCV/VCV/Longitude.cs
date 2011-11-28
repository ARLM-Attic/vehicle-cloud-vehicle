using System;

namespace VCV
{
    public struct Longitude
    {
        private Double _Degrees;
        private Double _Minutes;
        private Double _Seconds;

        public Double Degrees 
        {
            get { return _Degrees; }
            set
            {
                if (Math.Abs(value) < 90.0)
                {
                    _Degrees = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        
        }

        public Double Minutes
        {
            get { return _Minutes; }
            set
            {
                if (Math.Abs(value) < 90.0)
                {
                    _Minutes = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

        }

        public Double Seconds
        {
            get { return _Seconds; }
            set
            {
                if (Math.Abs(value) < 90.0)
                {
                    _Seconds = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}

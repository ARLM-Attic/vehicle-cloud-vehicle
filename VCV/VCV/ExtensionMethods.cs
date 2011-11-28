using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VCV
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Converts degrees to Radians.
        /// </summary>
        /// <returns>Returns a radian from degrees.</returns>
        public static Double ToRadian(this Double degree) 
        { 
            //Use F# helper.
            //return (degree * Math.PI / 180.0);
            return Helper.degrees_to_radians(degree);
        }

        /// <summary>
        /// To degress from a radian value.
        /// </summary>
        /// <returns>Returns degrees from radians.</returns>
        public static Double ToDegree(this Double radian) 
        { 
            //return (radian / Math.PI * 180.0);
            return Helper.radians_to_degrees(radian);
        }
    }
}

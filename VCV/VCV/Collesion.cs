using System;

namespace VCV
{
    public class Collesion : ICollesion
    {
        public DateTime EstimatedTime { get; set; }
        public IPoint Predicted { get; set; }
    }
}

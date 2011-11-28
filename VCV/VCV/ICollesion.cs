using System;

namespace VCV
{
    interface ICollesion
    {
        DateTime EstimatedTime { get; set; }
        IPoint Predicted { get; set; }
    }
}

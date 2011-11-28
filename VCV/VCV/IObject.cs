using System;

namespace VCV
{
    public interface IObject
    {
        Guid Id { get; }
        IPoint Current { get; set; }
        IVelocity Heading { get; set; }
        DateTime LogDate { get; set; }
        TimeSpan Staleness { get; set; }
    }
}

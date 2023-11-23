using System;

namespace RacingFamily.Models.Transport.Base;

public interface ITransport
{
    public string Name { get; set; }
    TimeSpan GetDistanceTime(double distance);
}
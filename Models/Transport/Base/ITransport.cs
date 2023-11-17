using System;

namespace RacingFamily.Models.Transport.Base;

public interface ITransport
{
    TimeSpan GetDistanceTime(double distance);
}
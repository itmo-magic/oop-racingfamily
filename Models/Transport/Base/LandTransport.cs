using System;

namespace RacingFamily.Models.Transport.Base;

public abstract class LandTransport : ITransport
{
    protected double Speed;
    protected double MoveTime;
    protected double TimeToRest;
    protected double RestIncrement;

    public string Name { get; set; }

    public TimeSpan GetDistanceTime(double distance)
    {
        double restCount = Math.Floor(distance / MoveTime);
        double restTime = 0;
        for (int i = 0; i < restCount; i++)
        {
            restTime += TimeToRest;
            TimeToRest += RestIncrement;
        }
        double rideTime = distance / Speed;
        
        return TimeSpan.FromMinutes(rideTime + restTime);
    }
}
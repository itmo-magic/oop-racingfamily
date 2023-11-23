using System;

namespace RacingFamily.Models.Transport.Base;

public abstract class LandTransport : ITransport
{
    protected double MoveTime;
    protected double TimeToRest;
    protected double RestIncrement;

    public string Name { get; set; }
    public double Speed { get; set; }

    public Rally.TypeRally GetRallyType()
    {
        return Rally.TypeRally.Land;
    }

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
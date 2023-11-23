using System;

namespace RacingFamily.Models.Transport.Base;

public abstract class FlyingTransport : ITransport
{
    protected double Speed;
    
    public TimeSpan GetDistanceTime(double distance)
    {
        var accel = GetAccelerationRatio(distance);
        double time = 0;
        while (distance != 0)
        {
            distance -= Speed;
            if (distance - Speed * accel < 0)
            {
                time += distance / (Speed * accel);
                distance = 0;
            }
            Speed *= accel;
        }

        return TimeSpan.FromMinutes(time);
    }

    public abstract double GetAccelerationRatio(double distance);
}
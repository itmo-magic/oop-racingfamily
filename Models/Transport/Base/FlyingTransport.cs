using System;

namespace RacingFamily.Models.Transport.Base;

public abstract class FlyingTransport : ITransport
{
    public string Name { get; set; }
    public double Speed { get; set; }

    public string GetRallyType()
    {
        return "Воздушная";
    }

    public TimeSpan GetDistanceTime(double distance)
    {
        var accel = GetAccelerationRatio(distance);
        double time = 0;
        double speed = Speed;
        while (distance != 0)
        {
            distance -= speed;
            if (distance - speed * accel < 0)
            {
                time += distance / (speed * accel);
                distance = 0;
            }
            speed *= accel;
        }

        return TimeSpan.FromMinutes(time);
    }

    public abstract double GetAccelerationRatio(double distance);
}
using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Transport.Flying;

public class BabaYaga : FlyingTransport
{
    public BabaYaga()
    {
        Name = "Баба-яга";
        Speed = 50;
    }
    public override double GetAccelerationRatio(double distance)
    {
        return distance / 5;
    }
}
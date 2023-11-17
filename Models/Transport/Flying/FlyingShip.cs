using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Transport;

public class FlyingShip: FlyingTransport
{
    public FlyingShip()
    {
        Speed = 5;
    }
    public override double GetAccelerationRatio(double distance)
    {
        return distance / 3;
    }
}
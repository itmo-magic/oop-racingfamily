using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Transport.Flying;

public class FlyingShip: FlyingTransport
{
    public FlyingShip()
    {
        Name = "Летучий корабль";
        Speed = 5;
    }
    public override double GetAccelerationRatio(double distance)
    {
        return distance / 3;
    }
}
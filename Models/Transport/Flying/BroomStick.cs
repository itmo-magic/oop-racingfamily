using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Transport;

public class BroomStick : FlyingTransport
{
    public BroomStick()
    {
        Speed = 10;
    }
    public override double GetAccelerationRatio(double distance)
    {
        return distance / 4;
    }
}
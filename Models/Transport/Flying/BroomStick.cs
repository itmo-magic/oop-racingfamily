using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Transport.Flying;

public class BroomStick : FlyingTransport
{
    public BroomStick()
    {
        Name = "Метла";
        Speed = 10;
    }
    public override double GetAccelerationRatio(double distance)
    {
        return distance / 4;
    }
}
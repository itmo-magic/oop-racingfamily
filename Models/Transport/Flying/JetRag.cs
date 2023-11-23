using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Transport.Flying;

public class JetRag : FlyingTransport
{
    public JetRag()
    {
        Name = "Ковер-самолет";
        Speed = 40;
    }

    public override double GetAccelerationRatio(double distance)
    {
        return distance / 100;
    }
}
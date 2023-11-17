namespace RacingFamily.Models.Transport;

public class JetRag : FlyingTransport
{
    public JetRag()
    {
        Speed = 40;
    }

    public override double GetAccelerationRatio(double distance)
    {
        return distance / 100;
    }
}
namespace RacingFamily.Models.Transport.Old;

public class BabaYaga : FlyingTransport
{
    public BabaYaga()
    {
        Speed = 50;
        
    }
    public override double GetAccelerationRatio(double distance)
    {
        return distance / 5;
    }
}
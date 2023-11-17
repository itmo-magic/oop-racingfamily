using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Transport.Land;

public class PumpkinCoach : LandTransport
{
    public PumpkinCoach()
    {
        Speed = 15;
        RestIncrement = 20;
        TimeToRest = 2;
        MoveTime = 10;
    }
}
using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Transport.Land;

public class Centaur : LandTransport
{
    public Centaur()
    {
        Name = "Кентавр";
        Speed = 40;
        RestIncrement = 5;
        TimeToRest = 15;
        MoveTime = 4;
    }
}
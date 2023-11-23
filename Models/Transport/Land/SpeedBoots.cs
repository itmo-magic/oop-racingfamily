using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Transport.Land;

public class SpeedBoots : LandTransport
{
    public SpeedBoots()
    {
        Name = "Сапоги-скороходы";
        Speed = 50;
        MoveTime = 100;
        TimeToRest = 100;
        RestIncrement = 100;
    }
}
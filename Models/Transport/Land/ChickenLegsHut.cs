using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Transport.Land;

public class ChickenLegsHut : LandTransport
{
    public ChickenLegsHut()
    {
        Name = "Избушка на курьих ножках";
        Speed = 30;
        RestIncrement = 10;
        MoveTime = 90;
        TimeToRest = 40;
    }
}
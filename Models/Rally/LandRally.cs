using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Rally;

public class LandRally : Rally
{
    public override bool ValidateRaceConditions()
    {
        foreach (ITransport transport in Transports)
        {
            if (transport is not LandTransport)
            {
                return false;
            }
        }

        return true;
    }
}
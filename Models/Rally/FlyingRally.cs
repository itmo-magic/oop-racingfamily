using System;
using RacingFamily.Models.Transport;
using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Rally;

public class FlyingRally : Rally
{
    public override bool ValidateRaceConditions()
    {
        foreach (ITransport transport in Transports)
        {
            if (transport is not FlyingTransport)
            {
                return false;
            }
        }

        return true;
    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;
using RacingFamily.Models.Rally.Interfaces;
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

    public LandRally(string name, int distance)
    {
        Distance = distance;
        Name = name;
        Transports = new ObservableCollection<ITransport>();
    }
}
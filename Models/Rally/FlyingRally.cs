using System.Collections.ObjectModel;
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

    public FlyingRally(string name, int distance)
    {
        Distance = distance;
        Name = name;
        Transports = new ObservableCollection<ITransport>();
    }
}
using System.Collections.Generic;
using RacingFamily.Models.Rally.Interfaces;

namespace RacingFamily.Models.Rally;

public class FlyingRallyCreator : IRallyCreator
{
    public Rally CreateRally(string name, int distance)
    {
        var rally = new FlyingRally(name, distance);
        RallyCollection.Rallies.Add(rally);
        return rally;
    }
}
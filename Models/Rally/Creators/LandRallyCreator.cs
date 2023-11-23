using RacingFamily.Models.Rally.Interfaces;

namespace RacingFamily.Models.Rally.Creators;

public class LandRallyCreator : IRallyCreator
{
    public Rally CreateRally(string name, int distance)
    {
        var rally = new LandRally(name, distance);
        RallyCollection.Rallies.Add(rally);
        return rally;
    }
}
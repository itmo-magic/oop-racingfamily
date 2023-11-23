using System.Collections.Generic;

namespace RacingFamily.Models.Rally.Interfaces;

public interface IRallyCreator
{
    public Rally CreateRally(string name, int distance);
}
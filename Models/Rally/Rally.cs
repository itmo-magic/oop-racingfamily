using System;
using System.Collections.Generic;
using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Rally;

public abstract class Rally
{
    protected int Distance;
    protected List<ITransport> Transports = new();

    public abstract bool ValidateRaceConditions();

    public void AddTransport(ITransport transport)
    {
        Transports.Add(transport);
    }
    
    public Tuple<ITransport, TimeSpan> GetWinner()
    {
        TimeSpan winnerTime = TimeSpan.MaxValue;
        ITransport winner = null!;
        foreach (var transport in Transports)
        {
            var resultTime = transport.GetDistanceTime(Distance);
            if (resultTime < winnerTime)
            {
                winnerTime = resultTime;
                winner = transport;
            }
        }

        return new Tuple<ITransport, TimeSpan>(winner, winnerTime);
    }
}
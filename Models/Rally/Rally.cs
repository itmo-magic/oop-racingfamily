using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DynamicData.Binding;
using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Rally;

public abstract class Rally
{
    protected Rally(string name, int distance)
    {
        Distance = distance;
        Name = name;
        Transports = new ObservableCollection<ITransport>();
    }

    protected int Distance { get; set; }
    public string Name { get; set; }
    public ObservableCollection<ITransport> Transports { get; set; }

    public abstract bool ValidateRaceConditions();
    
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
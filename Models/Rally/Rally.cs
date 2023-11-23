using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DynamicData.Binding;
using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Models.Rally;

public enum TypeRally
{
    Flying,
    Land
}

public abstract class Rally
{
    protected Rally(string name, int distance)
    {
        Distance = distance;
        Name = name;
        Transports = new ObservableCollection<ITransport>();
        Type = GetRallyType();
    }

    protected int Distance { get; set; }
    public string Name { get; set; }
    public TypeRally Type { get; set; }
    public ObservableCollection<ITransport> Transports { get; set; }

    public abstract bool ValidateRaceConditions();
    
    public abstract TypeRally GetRallyType();
    
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
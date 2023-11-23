using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DynamicData;
using RacingFamily.Models.Transport.Base;
using RacingFamily.Models.Transport.Flying;
using RacingFamily.Models.Transport.Land;

namespace RacingFamily.Models.Rally;

public static class RallyCollection
{
    public static ObservableCollection<Rally> Rallies { get; set; } = new();

    public static void FillSomeData()
    {
        var landRally = new LandRally("Наземная гонка", 300);
        var flyingRally = new FlyingRally("Воздушная гонка", 1000);
        
        Rallies.Add(landRally);
        Rallies.Add(flyingRally);
        landRally.Transports.Add(new Centaur());
        landRally.Transports.Add(new SpeedBoots());
        landRally.Transports.Add(new ChickenLegsHut());
        flyingRally.Transports.Add(new BroomStick());
        flyingRally.Transports.Add(new FlyingShip());
        flyingRally.Transports.Add(new BabaYaga());
    }
}
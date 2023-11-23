using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using Avalonia.Controls;
using DynamicData;
using RacingFamily.Models.Rally;
using RacingFamily.Models.Transport.Base;
using RacingFamily.Models.Transport.Flying;
using ReactiveUI;

namespace RacingFamily.ViewModels;

public class NewRallyViewModel : ViewModelBase
{
    public ReactiveCommand<List<object?>, Unit> CreateRallyCommand { get; set; }

    public NewRallyViewModel()
    {
        CreateRallyCommand = ReactiveCommand.Create<List<object?>>(CreateRally);
    }

    private void CreateRally(List<object?> vals)
    {
        string? param = vals[0] != null ? (string)((ComboBoxItem?)vals[0]).Content : null;
        string name = (string?)vals[1] ?? "";
        int distance = int.Parse((string)vals[2]!);

        if (vals[0] != null && param == "Наземная")
        {
            var rally = new LandRally(name, distance);
            rally.Transports.Add(new BabaYaga());
            RallyCollection.Rallies.Add(rally);
        }
        else if (param == "Воздушная")
        {
            var rally = new FlyingRally(name, distance);
            RallyCollection.Rallies.Add(rally);
        }
        
    }
}
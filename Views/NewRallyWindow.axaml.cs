using System;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Interactivity;
using DynamicData;
using RacingFamily.Models.Rally;
using RacingFamily.Models.Transport.Base;
using RacingFamily.Models.Transport.Flying;
using RacingFamily.Models.Transport.Land;

namespace RacingFamily.Views;

public partial class NewRallyWindow : Window
{
    public NewRallyWindow()
    {
        InitializeComponent();
    }

    private void Save(object? sender, RoutedEventArgs e)
    {
        var paramus = TypeBox.SelectedItem;
        string? param = "";
        if (paramus is not null)
            param = (string?)((ComboBoxItem)paramus).Content;
        string? name = NameBox.Text;
        int distance;
        int.TryParse(DistanceBox.Text, out distance);

        if (param == "Наземная")
        {
            var rally = new LandRally(name, distance);
            RallyCollection.Rallies.Add(rally);
            rally.Transports = new ObservableCollection<ITransport>();
        }
        else if (param == "Воздушная")
        {
            var rally = new FlyingRally(name, distance);
            RallyCollection.Rallies.Add(rally);
            rally.Transports = new ObservableCollection<ITransport>();
        }
    
        Close();
    }
}
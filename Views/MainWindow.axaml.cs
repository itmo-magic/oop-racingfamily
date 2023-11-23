using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using DynamicData;
using RacingFamily.Models.Rally;
using RacingFamily.Models.Transport.Base;
using RacingFamily.Models.Transport.Flying;
using RacingFamily.ViewModels;

namespace RacingFamily.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OpenNewRallyWindow(object? sender, RoutedEventArgs e)
    {
        var newRally = new NewRallyWindow();
        var result = newRally.ShowDialog(this);
    }

    private void CellPressed(object? sender, DataGridCellPointerPressedEventArgs e)
    {
        var grid = sender as DataGrid;

        var item = grid.SelectedItem as Rally;
        if (item != null)
        {
            TransportGrid.ItemsSource = item.Transports;
        }
    }

    private void ButtonClick(object? sender, RoutedEventArgs e)
    {
        if (TransportGrid.ItemsSource is List<ITransport> context)
            context.Add(new BabaYaga());
    }
}
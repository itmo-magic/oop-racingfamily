using System;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Interactivity;
using RacingFamily.Models.Rally;
using RacingFamily.Models.Transport.Base;

namespace RacingFamily.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        RallyCollection.FillSomeData();
    }

    private void OpenNewRallyWindow(object? sender, RoutedEventArgs e)
    {
        var newRally = new NewRallyWindow();
        newRally.ShowDialog(this);
    }

    private void CellPressed(object? sender, DataGridCellPointerPressedEventArgs e)
    {
        var grid = sender as DataGrid;

        var item = grid.SelectedItem as Rally;
        if (item != null)
        {
            TransportGrid.ItemsSource = item.Transports;
            TransportGrid.DataContext = item;
        }
    }

    private void ButtonClick(object? sender, RoutedEventArgs e)
    {
        var item = TransportBox.SelectedItem as ComboBoxItem;
        var transports = TransportGrid.ItemsSource as ObservableCollection<ITransport>;
        var name = "";
        if (item != null)
            name = (string?)item.Tag;
        var type = Type.GetType(name);
        if (type != null && transports != null)
        {
            var transport = (ITransport)Activator.CreateInstance(type);
            transports.Add(transport);
        }
    }

    private void StartRally(object? sender, RoutedEventArgs e)
    {
        var rally = TransportGrid.DataContext as Rally;
        if (rally != null && rally.Transports.Count != 0 && rally.ValidateRaceConditions())
        {
            var result = rally.GetWinner();
            ResultWindow window = new ResultWindow();
            window.MessageLabel.Content = "Победитель:";
            window.WinnerLabel.Content =  result.Item1.Name;
            window.TimeLabel.Content = "Результат:";
            window.TimeResultLabel.Content = result.Item2;
            window.ShowDialog(this);
        }
        else
        {
            var errorWindow = new ErrorWindow();
            var type = rally.GetRallyType() == TypeRally.Flying ? "Наземная" : "Воздушная";
            errorWindow.MessageLabel.Text = "Ошибка в конфигурации гонки\nПрисутствуют транспорт различных категорий\n" +
                                       "Тип текущей гонки: " + type;
            errorWindow.Show();
        }
    }

    private void RemoveRally(object? sender, RoutedEventArgs e)
    {
        var item = RallyGrid.SelectedItem as Rally;
        RallyCollection.Rallies.Remove(item); 
        TransportGrid.DataContext = null;
        TransportGrid.ItemsSource = null;
    }

    private void RemoveTransport(object? sender, RoutedEventArgs e)
    {
        var transports = (TransportGrid.DataContext as Rally).Transports;
        var item = TransportGrid.SelectedItem as ITransport;
        transports.Remove(item);
    }
}
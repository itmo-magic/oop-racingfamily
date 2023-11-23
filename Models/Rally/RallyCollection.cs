using System.Collections.ObjectModel;

namespace RacingFamily.Models.Rally;

public static class RallyCollection
{
    //private static ObservableCollection<Rally> _rallies = new();

    public static ObservableCollection<Rally> Rallies { get; set; } = new();
}
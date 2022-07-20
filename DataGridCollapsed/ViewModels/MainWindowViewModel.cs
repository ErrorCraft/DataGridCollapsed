using System.Collections.ObjectModel;

namespace DataGridCollapsed.ViewModels;
public class MainWindowViewModel : ViewModelBase {
    public ObservableCollection<CommandCount> Commands { get; } = new ObservableCollection<CommandCount>() {
        new CommandCount("a", 5, 0),
        new CommandCount("b", 10, 3),
        new CommandCount("c", 8, 2)
    };
}

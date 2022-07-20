namespace DataGridCollapsed;

public class CommandCount {
    public string Name { get; }
    public int Count { get; }
    public int ExecuteCount { get; }

    public CommandCount(string name, int count, int executeCount) {
        Name = name;
        Count = count;
        ExecuteCount = executeCount;
    }
}

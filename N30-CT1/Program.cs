
using N30_CT1;

public class Program
{
    static async Task Main(string[] args)
    {
        var taskService = new TaskService();

        List<TaskItem> tasks = await taskService.LoadTasksAsync();

        TaskItem newTaskA = new TaskItem
        {
            ID = 1,
            Description = "Pepsi",
            IsCompleted = true
        };
        await taskService.AddTaskAsync(tasks, newTaskA);
        TaskItem newTaskB = new TaskItem
        {
            ID = 2,
            Description = "Coca-cola",
            IsCompleted = true
        };
        await taskService.AddTaskAsync(tasks, newTaskB);

        TaskItem newTaskC = new TaskItem
        {
            ID = 3,
            Description = "Fanta",
            IsCompleted = true
        };
        await taskService.AddTaskAsync(tasks, newTaskC);
    }
} 
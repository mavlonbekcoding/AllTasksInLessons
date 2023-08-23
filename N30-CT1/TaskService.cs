using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.Json;
using Newtonsoft.Json;

namespace N30_CT1
{
    public class TaskService
    {
        private const string FilePath = "D:\\Async.json";

        public async Task AddTaskAsync(List<TaskItem> tasks, TaskItem newTask)
        {
            tasks.Add(newTask);
            await SaveTasksAsync(tasks);
        }

        public void CompleteTasks(List<TaskItem> tasks, List<int> taskIds)
        {
            foreach (var taskId in taskIds)
            {
                var task = tasks.Find(t => t.ID == taskId);
                if (task != null)
                {
                    task.IsCompleted = true;
                }
            }
            SaveTasksAsync(tasks);
        }

        public async Task SaveTasksAsync(List<TaskItem> tasks)
        {
            string json = JsonConvert.SerializeObject(tasks, Newtonsoft.Json.Formatting.Indented);
            await File.WriteAllTextAsync(FilePath, json);
        }

        public async Task<List<TaskItem>> LoadTasksAsync()
        {
            if (File.Exists(FilePath))
            {
                string json = await File.ReadAllTextAsync(FilePath);
                return JsonConvert.DeserializeObject<List<TaskItem>>(json);
            }
            return new List<TaskItem>();
        }
    }
}

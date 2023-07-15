using System;
using System.IO;
using System.Collections.Generic;

namespace TaskManagementSystem
{
    class FileHandler
    {
        private string filePath;

        public FileHandler(string filePath)
        {
            this.filePath = filePath;
        }

        public void SaveToFile(TaskManager taskManager)
        {
            // Implementation for SaveToFile method
            // ...

            // Call the WriteToFile method
            WriteToFile(taskManager);
        }

        public void LoadFromFile(TaskManager taskManager)
        {
            // Implementation for LoadFromFile method
            // ...
        }

        public void WriteToFile(TaskManager taskManager)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    List<Task> tasks = taskManager.GetTasks();

                    foreach (Task task in tasks)
                    {
                        writer.WriteLine($"{task.TaskID},{task.TaskName},{task.Description},{task.Deadline},{task.Priority},{task.Status}");
                    }
                }

                Console.WriteLine("Tasks saved to file successfully!");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error while saving tasks to file: {e.Message}");
            }
        }
    }
}

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

        public FileHandler()
        {
        }

        public void SaveToFile(TaskManager taskManager)
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

        public void LoadFromFile(TaskManager taskManager)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] taskData = line.Split(',');

                            string taskID = taskData[0];
                            string taskName = taskData[1];
                            string description = taskData[2];
                            DateTime deadline = DateTime.Parse(taskData[3]);
                            int priority = int.Parse(taskData[4]);
                            string status = taskData[5];

                            Task task = new Task(taskID, taskName, description, deadline, priority, status);
                            taskManager.AddTask(task);
                        }
                    }

                    Console.WriteLine("Tasks loaded from file successfully!");
                }
                else
                {
                    Console.WriteLine("No file found. No tasks loaded.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error while loading tasks from file: {e.Message}");
            }
        }

        internal void ReadFromFile(TaskManager taskManager)
        {
            throw new NotImplementedException();
        }

        internal void WriteToFile(TaskManager taskManager)
        {
            throw new NotImplementedException();
        }
    }
}

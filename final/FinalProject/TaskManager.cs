using System;
using System.Collections.Generic;

namespace TaskManagementSystem
{
    class TaskManager
    {
        private List<Task> tasks;

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }

        public Task GetTaskByID(string taskID)
        {
            foreach (Task task in tasks)
            {
                if (task.TaskID == taskID)
                {
                    return task;
                }
            }

            return null;
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }
    }
}

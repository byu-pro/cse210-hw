using System;

namespace TaskManagementSystem
{
    class UserInterface
    {
        public void DisplayMenu()
        {
            Console.WriteLine("===== Task Management System Menu =====");
            Console.WriteLine("1. Create a new task");
            Console.WriteLine("2. Assign priority to a task");
            Console.WriteLine("3. Set deadline for a task");
            Console.WriteLine("4. View task details");
            Console.WriteLine("5. Save tasks to file");
            Console.WriteLine("6. Load tasks from file");
            Console.WriteLine("0. Exit");
            Console.WriteLine("=======================================");
        }

        public Task CreateTask()
        {
            Console.WriteLine("Enter task details:");

            Console.Write("Task ID: ");
            string taskID = Console.ReadLine();

            Console.Write("Task Name: ");
            string taskName = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Deadline (yyyy-mm-dd): ");
            DateTime deadline = DateTime.Parse(Console.ReadLine());

            Console.Write("Priority (1-5): ");
            int priority = int.Parse(Console.ReadLine());

            Console.Write("Status: ");
            string status = Console.ReadLine();

            Task newTask = new Task(taskID, taskName, description, deadline, priority, status);

            return newTask;
        }

        public void AssignPriority(TaskManager taskManager)
        {
            Console.WriteLine("Assigning priority to a task:");
            Console.Write("Enter the Task ID: ");
            string taskID = Console.ReadLine();

            Task task = taskManager.GetTaskByID(taskID);

            if (task != null)
            {
                Console.Write("Enter the new priority (1-5): ");
                int newPriority = int.Parse(Console.ReadLine());

                task.UpdatePriority(newPriority);

                Console.WriteLine("Priority updated successfully!");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        public void SetDeadline(TaskManager taskManager)
        {
            Console.WriteLine("Setting deadline for a task:");
            Console.Write("Enter the Task ID: ");
            string taskID = Console.ReadLine();

            Task task = taskManager.GetTaskByID(taskID);

            if (task != null)
            {
                Console.Write("Enter the new deadline (yyyy-mm-dd): ");
                DateTime newDeadline = DateTime.Parse(Console.ReadLine());

                task.UpdateDeadline(newDeadline);

                Console.WriteLine("Deadline updated successfully!");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        public void ViewTaskDetails(TaskManager taskManager)
        {
            Console.WriteLine("Viewing task details:");
            Console.Write("Enter the Task ID: ");
            string taskID = Console.ReadLine();

            Task task = taskManager.GetTaskByID(taskID);

            if (task != null)
            {
                Console.WriteLine(task.GetTaskInfo());
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }
    }
}

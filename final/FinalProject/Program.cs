using System;

namespace TaskManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            UserInterface userInterface = new UserInterface();
            FileHandler fileHandler = new FileHandler("tasks.txt");

            // Load tasks from file (if available)
            fileHandler.LoadFromFile(taskManager);

            bool exit = false;
            while (!exit)
            {
                userInterface.DisplayMenu();
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task newTask = userInterface.CreateTask();
                        taskManager.AddTask(newTask);
                        break;
                    case "2":
                        userInterface.AssignPriority(taskManager);
                        break;
                    case "3":
                        userInterface.SetDeadline(taskManager);
                        break;
                    case "4":
                        userInterface.ViewTaskDetails(taskManager);
                        break;
                    case "5":
                        fileHandler.SaveToFile(taskManager);
                        break;
                    case "6":
                        fileHandler.LoadFromFile(taskManager);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            // Save tasks to file before exiting
            fileHandler.WriteToFile(taskManager);

            Console.WriteLine("Task Management System exited. Goodbye!");
        }
    }
}

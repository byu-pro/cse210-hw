using System;

namespace TaskManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            UserInterface userInterface = new UserInterface();
            FileHandler fileHandler = new FileHandler();

            // Load tasks from file (if available)
            fileHandler.ReadFromFile(taskManager);

            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                userInterface.DisplayMenu();

                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Creating a new task:");
                        Task newTask = userInterface.CreateTask();
                        taskManager.AddTask(newTask);
                        Console.WriteLine("Task created successfully!");
                        break;
                    case "2":
                        Console.WriteLine("Assigning priority to a task:");
                        userInterface.AssignPriority(taskManager);
                        break;
                    case "3":
                        Console.WriteLine("Setting deadline for a task:");
                        userInterface.SetDeadline(taskManager);
                        break;
                    case "4":
                        Console.WriteLine("Viewing task details:");
                        userInterface.ViewTaskDetails(taskManager);
                        break;
                    case "5":
                        Console.WriteLine("Saving tasks to file...");
                        fileHandler.SaveToFile(taskManager);
                        Console.WriteLine("Tasks saved successfully!");
                        break;
                    case "6":
                        Console.WriteLine("Loading tasks from file...");
                        fileHandler.LoadFromFile(taskManager);
                        Console.WriteLine("Tasks loaded successfully!");
                        break;
                    case "0":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            // Save tasks to file before exiting
            fileHandler.WriteToFile(taskManager);

            Console.WriteLine("Task Management System has exited. Press any key to close the program...");
            Console.ReadKey();
        }
    }
}

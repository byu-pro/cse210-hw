using System;
using System.Threading;

// Base class for all activities
public abstract class Activity
{
    protected int duration;

    public void Run()
    {
        DisplayStartingMessage();
        Thread.Sleep(3000); // Pause for 3 seconds

        PerformActivity();

        DisplayEndingMessage();
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected abstract void DisplayStartingMessage();
    protected abstract void PerformActivity();
    protected abstract void DisplayEndingMessage();
}

// Breathing activity
public class BreathingActivity : Activity
{
    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected override void PerformActivity()
    {
        int count = 1;
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(count % 2 == 0 ? "Breathe out..." : "Breathe in...");
            Thread.Sleep(1000); // Pause for 1 second
            count++;
        }
    }

    protected override void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the Breathing Activity.");
        Console.WriteLine("Duration: " + duration + " seconds");
    }
}

// Reflection activity
public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("Reflection Activity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        int count = 0;

        while (count < duration)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);

            Console.WriteLine("Reflect on the following questions:");

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(3000); // Pause for 3 seconds
            }

            count += questions.Length;
        }
    }

    protected override void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the Reflection Activity.");
        Console.WriteLine("Duration: " + duration + " seconds");
    }
}

// Listing activity
public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        int count = 0;

        while (count < duration)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);

            Console.WriteLine("Think about the prompt and start listing items:");
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration - count);
            int itemsCount = 0;

            while (DateTime.Now <= endTime)
            {
                string item = Console.ReadLine();
                itemsCount++;
            }

            Console.WriteLine("Number of items listed: " + itemsCount);

            count += itemsCount;
        }
    }

    protected override void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the Listing Activity.");
        Console.WriteLine("Duration: " + duration + " seconds");
    }
}

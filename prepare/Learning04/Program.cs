// Program.cs

using System;

class Program
{
    static void Main()
    {
        // Create a MathAssignment object
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        // Display Math assignment summary
        Console.WriteLine(mathAssignment.GetSummary());

        // Display Math homework list
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Create a WritingAssignment object
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        // Display Writing assignment summary
        Console.WriteLine(writingAssignment.GetSummary());

        // Display Writing assignment information
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}

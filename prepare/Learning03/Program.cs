using System;

namespace Learning03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create fractions using all three constructors
            Fraction fraction1 = new Fraction();        // 1/1
            Fraction fraction2 = new Fraction(6);       // 6/1
            Fraction fraction3 = new Fraction(6, 7);    // 6/7

            // Verify the values using getters
            Console.WriteLine(fraction1.Top);           // 1
            Console.WriteLine(fraction1.Bottom);        // 1
            Console.WriteLine(fraction2.Top);           // 6
            Console.WriteLine(fraction2.Bottom);        // 1
            Console.WriteLine(fraction3.Top);           // 6
            Console.WriteLine(fraction3.Bottom);        // 7

            // Change the values using setters
            fraction1.Top = 5;
            fraction1.Bottom = 3;
            fraction2.Top = 3;
            fraction2.Bottom = 4;
            fraction3.Top = 2;
            fraction3.Bottom = 5;

            // Verify the new values using getters
            Console.WriteLine(fraction1.Top);           // 5
            Console.WriteLine(fraction1.Bottom);        // 3
            Console.WriteLine(fraction2.Top);           // 3
            Console.WriteLine(fraction2.Bottom);        // 4
            Console.WriteLine(fraction3.Top);           // 2
            Console.WriteLine(fraction3.Bottom);        // 5

            // Display the fraction and decimal representations
            Console.WriteLine(fraction1.GetFractionString());   // 5/3
            Console.WriteLine(fraction1.GetDecimalValue());     // 1.6666666666666667
            Console.WriteLine(fraction2.GetFractionString());   // 3/4
            Console.WriteLine(fraction2.GetDecimalValue());     // 0.75
            Console.WriteLine(fraction3.GetFractionString());   // 2/5
            Console.WriteLine(fraction3.GetDecimalValue());     // 0.4
        }
    }
}

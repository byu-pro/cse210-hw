using System;

namespace Learning03
{
    public class Fraction
    {
        private int top;
        private int bottom;

        // Constructor with no parameters
        public Fraction()
        {
            top = 1;
            bottom = 1;
        }

        // Constructor with one parameter for the top
        public Fraction(int top)
        {
            this.top = top;
            bottom = 1;
        }

        // Constructor with two parameters for the top and bottom
        public Fraction(int top, int bottom)
        {
            this.top = top;
            this.bottom = bottom;
        }

        // Getter and setter for the top value
        public int Top
        {
            get { return top; }
            set { top = value; }
        }

        // Getter and setter for the bottom value
        public int Bottom
        {
            get { return bottom; }
            set { bottom = value; }
        }

        // Method to return the fraction as a string
        public string GetFractionString()
        {
            return top + "/" + bottom;
        }

        // Method to return the decimal value of the fraction
        public double GetDecimalValue()
        {
            return (double)top / bottom;
        }
    }
}

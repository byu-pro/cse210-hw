// Fraction class
public class Fraction {
    private int numerator;   // attribute for the numerator
    private int denominator; // attribute for the denominator
    
    // Constructor with numerator and denominator
    public Fraction(int numerator, int denominator) {
        this.numerator = numerator;
        this.denominator = denominator;
    }
    
    // Getter for numerator
    public int getNumerator() {
        return numerator;
    }
    
    // Setter for numerator
    public void setNumerator(int numerator) {
        this.numerator = numerator;
    }
    
    // Getter for denominator
    public int getDenominator() {
        return denominator;
    }
    
    // Setter for denominator
    public void setDenominator(int denominator) {
        this.denominator = denominator;
    }
    
    // Method to return fractional representation
    public String getFractionalRepresentation() {
        return numerator + "/" + denominator;
    }
    
    // Method to return decimal representation
    public double getDecimalRepresentation() {
        return (double) numerator / denominator;
    }
}

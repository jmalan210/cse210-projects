using System;
using System.Diagnostics.Contracts;
public class Fraction
{
    private int _numerator = 0;
    private int _denominator = 0;


    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
       
    }

    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;

    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;

    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}
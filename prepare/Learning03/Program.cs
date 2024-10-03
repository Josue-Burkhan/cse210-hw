using System;
public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetdecimalV()
    {
        return (double)_top / (double)_bottom;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Fraction f01 = new Fraction();
        Console.WriteLine(f01.GetFractionString());
        Console.WriteLine(f01.GetdecimalV());

        Fraction f02 = new Fraction(5);
        Console.WriteLine(f02.GetFractionString());
        Console.WriteLine(f02.GetdecimalV());

        Fraction f03 = new Fraction(3, 4);
        Console.WriteLine(f03.GetFractionString());
        Console.WriteLine(f03.GetdecimalV());

        Fraction f04 = new Fraction(1, 3);
        Console.WriteLine(f04.GetFractionString());
        Console.WriteLine(f04.GetdecimalV());
    }
}
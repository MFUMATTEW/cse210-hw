using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Fraction w = new Fraction ();
        Console.WriteLine(w.GetFractionString());
        Console.WriteLine(w.GetDecimmalValue());

        Fraction x = new Fraction(5);
        Console.WriteLine(x.GetFractionString());
        Console.WriteLine(x.GetDecimmalValue());

        Fraction y = new Fraction (3, 4);
        Console.WriteLine(y.GetFractionString());
        Console.WriteLine(y.GetDecimmalValue());

        Fraction z = new Fraction (1, 3);
        Console.WriteLine(z.GetFractionString());
        Console.WriteLine(z.GetDecimmalValue());
    }   
}
using System;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square carré = new Square("blue",2);
        Console.WriteLine($"The {carré.GetColor()} square's area is {carré.GetArea()}cm^2");

        Rectangle rectangle = new Rectangle("red", 2, 4);
        Console.WriteLine($"The {rectangle.GetColor()} rectangle's area is {rectangle.GetArea()}cm^2");

        Circle circle = new Circle("green", 5);
        Console.WriteLine($"The {circle.GetColor()} circle's area is {circle.GetArea()}cm^2");
        
        
    }
}
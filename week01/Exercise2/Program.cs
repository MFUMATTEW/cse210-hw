using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("Enter your grade");
        string grade = Console.ReadLine();
        int x = int.Parse(grade);

        string letter = "";

        if (x < 60)
        {
            letter = "F";
        }
        else if (x >= 60 && x <= 69)
        {
            letter = "D";
        }
        else if (x >= 70 && x <= 79)
        {
            letter = "C";
        }
        else if (x >= 80 && x <= 89)
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry your Grade is not enough to pass the class, please try again next term");
        }
    }
}
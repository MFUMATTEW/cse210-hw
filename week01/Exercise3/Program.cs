using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess = -1;
        

        do
        {
           
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            

            if (magic < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }

        } while (magic != guess);
    }
}
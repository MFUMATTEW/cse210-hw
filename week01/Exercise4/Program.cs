using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

         Console.WriteLine("Enter a list of numbers, Type O when finished.");

        List<int> numbers = new List<int>();
        int response = 0;
        do
        {
            Console.Write("Enter number: ");
            response = int.Parse(Console.ReadLine());
            
            numbers.Add(response);
        } while (response != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
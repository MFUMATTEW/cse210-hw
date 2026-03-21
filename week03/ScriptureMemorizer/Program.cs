using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference,"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy path.");

         while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if(scripture.IsCompletelyHidden())
                break;

            Console.WriteLine("\nPress enter to hide more words...");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            scripture.HideRandomWords(2);
        }

        Console.WriteLine("The scripture is Hidden !");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {

        bool running = true;

        while(running)
        {
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",0);
                    breathing.Run();
                    break;

                case "2":
                    List<string> reflectionPrompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
                    List<string> reflectionQuestions = new List<string> {"Why was this experience meaningful to you?", "How did you get started?", "How can you keep this experience in mind in the future?", "What is your favorite thing about this experience?", "Have you ever done anything like this before?", "How did you feel when it was complete?", "What did you learn about yourself through this experience?"};
                    ReflectionActivity reflection = new ReflectionActivity("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0, reflectionPrompts, reflectionQuestions); 
                    reflection.Run(); 
                    break;

                case "3":
                    List<string> listingPrompts = new List<string> {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
                    ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, 0, listingPrompts);
                    listing.Run();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break; 

                default:  
                    Console.WriteLine("Invalid option. Please try again.");
                    break;                    
            }

            Console.WriteLine();
        }
    }
}
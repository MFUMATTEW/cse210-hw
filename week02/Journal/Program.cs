using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator questions= new PromptGenerator();
        questions._prompts= new List<string>
        {
            "When is your birthday?",
            "what is you favorite sport?",
            "What do you do for fun?",
            "Which advise would you give to your futur you?",
            "Describre a dangerous sitution you have been involved in"
        };

        Journal journal = new Journal();

        bool running = true;

        while (running)
        {
            Console.WriteLine("1 - Write");
            Console.WriteLine("2 - Display");
            Console.WriteLine("3 - Save");
            Console.WriteLine("4 - Load");
            Console.WriteLine("5 - Quit");
            Console.WriteLine("Chosse an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = questions.RandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.WriteLine("Your response: ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry
                    {
                        _date = DateTime.Now.ToString("dd/MM/yyy"),
                        _promptText = prompt,
                        _entryText = response
                    };

                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added!");
                    break;

                case "2":
                    Console.WriteLine("\n--- Journal Entries ---");
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.WriteLine("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break; 

                default:  
                    Console.WriteLine("Invalid option. Please try again.");
                    break;        
            }

        }

    }
}
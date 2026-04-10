using System.Diagnostics.SymbolStore;
using System.Net;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            _count++;
        }

        Console.WriteLine($"You listed {_count} items");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];

    }

    public List<string> GetListFromUser(List<string> responses)
    {
        Console.WriteLine("Responses");
        foreach (string i in responses)
        {
            Console.WriteLine($"~ {i}");
        }

        return responses;
    }
}
using Microsoft.VisualBasic;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {   
        DisplayStartingMessage(); 

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration()); 

        Thread.Sleep(2000);

        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
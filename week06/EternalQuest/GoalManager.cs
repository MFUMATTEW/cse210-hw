using System.Transactions;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        
        bool running = true;

        while(running)
        {
            Console.WriteLine();
            DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options:    ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    if (_goals.Count == 0)
                    {
                        Console.WriteLine("Load from a file first");
                    }
                    else
                    {
                        ListGoalNames();   
                    }
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    SaveGoals(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadfile = Console.ReadLine();
                    LoadGoal(loadfile);
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Goodbye");
                    break;
                default:  
                    Console.WriteLine("Invalid option. Please try again.");
                    break;                    
            }

        }    Console.WriteLine();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete() ? "[X]" : "[]";
            string name = _goals[i].GetShortName();
            string desc = _goals[i].GetDescription();
            string details = _goals[i].GetDetailsString();
            Console.WriteLine($"{i + 1}. {details}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string selection = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (selection)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points, false));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
       for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        Console.Write("Select the goal you have accomplished: ") ;

        int choice = int.Parse(Console.ReadLine()) -1;
        _goals[choice].RecordEvent();
        _score += _goals[choice].GetPoints();

        if (_goals[choice] is ChecklistGoal checklist)
        {
            if(checklist.IsComplete())
            {
                _score += checklist.GetBonus();
                Console.WriteLine($"Bonus achieved! You have earned {checklist.GetBonus()} extra points!");  
            }
            else
            {
                // Exceeding requirement: Motivation words
                int remaining = checklist.GetTarget() - checklist.GetAmountCompleted();
                if (remaining == 1)
                {
                    Console.WriteLine("You're almost there! Just one more to go!");
                }
                else if (remaining <= 2)
                {
                    Console.WriteLine("Keep going, you're close to finishing!");
                }
           
            }
        
        }

        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {_goals[choice].GetPoints()} points!");
    }

    public void SaveGoals(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Goals saved to {file}");
    }

    public void LoadGoal(string file)
    {
        if (File.Exists(file))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(file);
            _score = int.Parse(lines[0].Trim());

            for(int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    string name = parts[1].Trim();
                    string description = parts[2].Trim();
                    int points = int.Parse(parts[3].Trim());
                    bool isComplete = bool.Parse(parts[4].Trim());

                    _goals.Add(new SimpleGoal(name, description, points,isComplete));
                }
                else if (type == "EternalGoal")
                {
                    string name = parts[1].Trim();
                    string description = parts[2].Trim();
                    int points = int.Parse(parts[3].Trim());
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if ( type == "ChecklistGoal")
                {
                    string name = parts[1].Trim();
                    string description = parts[2].Trim();
                    int points = int.Parse(parts[3].Trim());
                    int amountCompleted = int.Parse(parts[4].Trim());
                    int target = int.Parse(parts[5].Trim());
                    int bonus = int.Parse(parts[6].Trim());

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);

                    goal.SetAmountCompleted(amountCompleted);

                    _goals.Add(goal);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"goals loaded from {file}");
        }
        else
        {
            Console.WriteLine($"File '{file}' not found.");
        }
    }
}
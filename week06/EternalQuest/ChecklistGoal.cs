public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public int GetBonus()
    {
        return _bonus;
    }

    public void SetAmountCompleted(int value)
    {
        _amountCompleted = value;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string level = IsComplete() ? "X" : "";
        return $"[{level}] {GetShortName()} ({GetDescription()}) -- Complete {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }
}
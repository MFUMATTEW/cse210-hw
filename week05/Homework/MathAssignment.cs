public class MathAssigment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssigment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"The section {_textbookSection}, problems{_problems}";
    }
}
public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
       return _topic; 
    }

    public void SetstudentName(string studentName)
    {
        _studentName = studentName;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"The assignment on the {_topic} has been done by {_studentName}";
    }
}
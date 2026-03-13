public class Resume
{
    public string _firstName;
    public string _lastName;

    public List<Job> _Job = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_firstName} {_lastName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _Job)
        {
            job.DisplayJobDetails();
        }
    }
}
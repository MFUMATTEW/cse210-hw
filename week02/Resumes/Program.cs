using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Console.WriteLine(""); 
        
        Job job1 = new Job();
        Job job2 = new Job();
    

        job1._jobTitle = "Software Engineer";
        job2._jobTitle = " Manager";

        job1._company= "Microsoft";
        job2._company= "Apple";

        job1._startYear= 2019;
        job2._startYear= 2022;

        job1._endYear= 2022;
        job2._endYear= 2023;

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        

        resume1._firstName= "Flavien";
        resume1._lastName= "Mabouba";

        resume1._Job.Add(job1);
        resume1._Job.Add(job2);

        resume1.DisplayResumeDetails();
    }
}
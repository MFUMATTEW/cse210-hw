using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment_x = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment_x.GetSummary());

        MathAssigment math_x = new MathAssigment("Samuel Blessing", "Multiplication","7.3","8-19" );
        Console.WriteLine(math_x.GetSummary());
        Console.WriteLine(math_x.GetHomeworkList());

        WritingAssignment writing_x = new WritingAssignment("Flavien Mabouba", "African History", "Bantu Empire");
        Console.WriteLine(writing_x.GetSummary());
        Console.WriteLine(writing_x.GetWritingInformation());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment ex1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(ex1.GetSummary());
        Console.WriteLine();

        MathAssignment ex2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(ex2.GetSummary());
        Console.WriteLine(ex2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment ex3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(ex3.GetSummary());
        Console.WriteLine(ex3.GetWritingInformation());
    }
}
class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}

class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}
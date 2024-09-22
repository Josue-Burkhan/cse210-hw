using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Tell me the % of your Grade: ");
        string answare = Console.ReadLine();
        int grade = int.Parse(answare);

        string letter = "";
        string exact_grade = "";

        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;

        if (grade >= A)
        {
            letter = "A";
        }
        else if (grade >= B)
        {
            letter = "B";
        }
        else if (grade >= C)
        {
            letter = "C";
        }
        else if (grade >= D)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade % 10 >= 7 && grade % 10 <=9) 
        {
            exact_grade = "+";
        }
        else if (grade % 10 >= 0 && grade % 10 <3)
        {
            exact_grade = "-";
        } 
        else
        {
            exact_grade = "";
        }

        Console.WriteLine($"Your Grade is: {letter}{exact_grade}");

        if (grade >= C) 
        {
            Console.Write("Great! You passed the course!");
        }

        else 
        {
            Console.Write("You didn't pass the course, but don't be discouraged, be prepared and you'll do better next time!");
        }
    }
}
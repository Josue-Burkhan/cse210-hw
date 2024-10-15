using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! You've completed the activity.");
        Console.WriteLine($"Activity: {_name}, Duration: {_duration} seconds.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b\b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b\b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b\b");

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b\b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.SetCursorPosition(17, 0);
            Console.WriteLine($"{i}");
            Thread.Sleep(1000);
        }
    }
}

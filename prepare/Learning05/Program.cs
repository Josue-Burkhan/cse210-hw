using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflecting Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the Menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}


public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int timeLeft = _duration;

        while (timeLeft > 0)
        {
            Console.Clear();
            Console.Write("Breathe in...");
            ShowCountDown(5);
            timeLeft -= 5;

            if (timeLeft <= 0) break;
            Console.Clear();
            Console.Write("Breathe out...");
            ShowCountDown(5);
            timeLeft -= 5;
        }

        DisplayEndingMessage();
    }
}
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        int timeLeft = _duration;

        while (timeLeft > 0)
        {
            Console.WriteLine();
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            ShowSpinner(5);
            timeLeft -= 5;
        }
        Console.Clear();
        DisplayEndingMessage();
    }
}
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        Console.Clear();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

        List<string> userList = new List<string>();
        int timeLeft = _duration;

        while (timeLeft > 0)
        {
            
            Console.WriteLine(" ");
            Console.Write("List an item: ");
            userList.Add(Console.ReadLine());
            timeLeft -= 5;
        }
        Console.Clear();
        Console.WriteLine($"You listed {userList.Count} items.");
        DisplayEndingMessage();
    }
}

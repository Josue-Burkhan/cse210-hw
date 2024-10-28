using System;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 5.0),
            new Cycling(new DateTime(2022, 11, 3), 30, 18.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 21)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}


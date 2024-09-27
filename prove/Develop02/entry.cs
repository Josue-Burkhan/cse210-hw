using System;

class Entry
{
    public string Prompt {get; set;}
    public string Response {get; set;}
    public DateTime Date {get; set;}

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }

    public void Display()
    {

        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    public string ToFileFormat()
    {
        return $"{Date} | {Prompt} | {Response}";
    }

    public static Entry FromFileFormat(string fileLine)
    {
        string[] parts = fileLine.Split('|');
        DateTime date = DateTime.Parse(parts[0]);
        string prompt = parts[1];
        string response = parts[2];

        Entry entry = new Entry(prompt, response);
        entry.Date = date;
        return entry;
    }
}
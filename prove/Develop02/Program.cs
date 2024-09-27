using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool exit = false;

        while (!exit) {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save to a file");
            Console.WriteLine("4. Load from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1") {
                journal.AddEntry();
            }

            else if (choice == "2") {
                journal.DisplayJournal();
            }
            
            else if (choice == "3") {
                Console.Write("Enter the filename to save: ");
                string saveFilename = Console.ReadLine();
                journal.SaveJournal(saveFilename);
            }

            else if (choice == "4") {
                Console.Write("Enter the filename to load: ");
                string loadFilename = Console.ReadLine();
                journal.LoadJournal(loadFilename);
            }

            else if (choice == "5") {
                exit = true;
                Console.WriteLine("Exiting the program...");
                break;
            }

            else {
                Console.WriteLine("Invalid option. Please try again.");
            }

        }
    }
}
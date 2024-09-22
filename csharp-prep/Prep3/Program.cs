using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ")
        //int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine("I'm thinking of a magic number, try to guess it :)");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess_number = 0;

        while (guess_number != number)
        {
            Console.Write("What is your guess? ");
            guess_number = int.Parse(Console.ReadLine());

            if (guess_number < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess_number > number)
            {
                Console.WriteLine("Lower");
            }

        }

        Console.WriteLine("Nice, you guessed it!");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);
        
        int guess = -1;
        while (guess != magicNumber)
        {
            Console.Write("What is your guess?  ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guess it correctly!");
            }
        }
        
    }
}
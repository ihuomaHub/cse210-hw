using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?  ");
        string userInput = Console.ReadLine();
        Console.Write("What is your guess?  ");
        string userGuess = Console.ReadLine();
        
        int margicNumber = int.Parse(userInput);
        int guessNumber = int.Parse(userGuess);

        if (margicNumber > guessNumber)
        {
            Console.WriteLine("higher");
        }
        else if (margicNumber < guessNumber)
        {
            Console.WriteLine("lower");
        }
        else
        {
            Console.WriteLine("You guess it!");
        }
    }
    
}
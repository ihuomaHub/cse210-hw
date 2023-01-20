using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage ");
        string userInput = Console.ReadLine();

        int x = int.Parse(userInput);
        int y = 90;
        int z = 80;
        int m = 70;
        int n = 60;
        
        if (x >= y)
        {
            Console.Write("Your grade is A");
        }
        else if (x >= z && x < y)
        {
            Console.Write("Your grade is B");
        } 
        else if (x >= m && x < z)
        {
            Console.Write("Your grade is C");
        }
        else if (x >= n && x < m)
        {
            Console.Write("Your grade is D");
        }
        else
        {
            Console.Write("Your grade is F");
        }
    }
}
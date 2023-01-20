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
            Console.WriteLine("Your grade is A");
        }
        else if (x >= z && x < y)
        {
            Console.WriteLine("Your grade is B");
        } 
        else if (x >= m && x < z)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (x >= n && x < m)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }
        if (x >= m)
        {
            Console.WriteLine("You passed the course! Congratulations! Keep it up");
        }
        else
        {
            Console.WriteLine("You didn't pass the course. Please put more effort, you can make it!");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage ");
        string userInput = Console.ReadLine();
        string letter = "";

        int x = int.Parse(userInput);
       
        
        
        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        } 
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");


        if (x >= 70)
        {
            Console.WriteLine("You passed the course! Congratulations! Keep it up");
        }
        else
        {
            Console.WriteLine("You didn't pass the course. Please put more effort, you can make it!");
        }
    }
}
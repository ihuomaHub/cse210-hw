using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Computing the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of the numbers in the list is: {sum}");

        // Part 2: Computing the average
      
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average number in the list is: {average}");

        // Part 3: Finding the max
       
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The maximum number in the list is: {max}");

        // The Stretch Activity: Finding the minimum number

        int min = numbers[0];
        
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        
        }

        Console.WriteLine($"The minimum number in the list is: {min}");
        Console.WriteLine($"The total number entered is {numbers.Count}");
        
        // The Stretch Activity: Finding the minimum positive number

        int minPositive = numbers[0];
        foreach (int number in numbers)
        {
            if (number > 0 && number < minPositive)
            {
                minPositive = number;
            }
        }
        Console.WriteLine($"The minimum positive number in the list is: {minPositive}");

        // The Stretch Activity: Sorting the numbers entered by the user
        Console.WriteLine("The Sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        
        {
            Console.WriteLine($"{number}");  
        }
       

    }
}
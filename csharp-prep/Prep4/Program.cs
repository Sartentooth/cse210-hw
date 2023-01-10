using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<int> newNum = new List<int>();

        bool exit = false;
        int sum = 0;
        
        do
        {
            Console.Write("Enter a list of numbers (type 0 when finished): ");
            string userInput = Console.ReadLine();
            int num = int.Parse(userInput);

            if (num == 0)
            {
                exit = true;
            }
            else                
                numbers.Add(num);

        } while (exit != true);

        foreach (int number in numbers)
        {
            sum += number;
        }
        float average = (float)sum / numbers.Count;
        int max = numbers.Max();
        foreach (int numb in numbers)
        {
            if (numb > 0)
            {
                newNum.Add(numb);
            }
        }
        int min = newNum.Min();
        numbers.Sort();

        Console.WriteLine(sum);      
        Console.WriteLine($"the average is: {average}");        
        Console.WriteLine($"the max number is: {max}");
        Console.WriteLine($"the min positive number is: {min}");
        Console.WriteLine("the sorted list is: ");

        foreach (int numb in numbers)
        {
            Console.WriteLine(numb);
        }
    }   
}

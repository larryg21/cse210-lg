using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    {
        List<int> numbers = new List<int>();

        Console.WriteLine($"Enter a list of numbers, type 0 when finished.");

        int Number = -1;

        while (Number != 0)

        {
            Console.Write($"Enter number: ");
            string answer = Console.ReadLine();

            Number = int.Parse(answer);

            if (Number != 0)

            {
                numbers.Add(Number);
            }

        }

        int sum = 0;
        foreach (int number in numbers)

        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average} ");

        int largest = numbers[0];

        foreach (int number in numbers)

        {
            if (number > largest)

            {
                largest = number;

            }

        }

        Console.WriteLine($"The largest number is: {largest} ");

    }

}
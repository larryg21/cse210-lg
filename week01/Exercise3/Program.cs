using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)


    {

        // For Part 1 & 2. 

        //Console.Write("What is the magic number? ");
        //int rightNumber = int.Parse(Console.ReadLine());

        //Console.Write("What is your guess? ");
        //int guessNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int rightNumber = randomGenerator.Next(1, 101);

        int guessNumber = -1;

        


        while (guessNumber != rightNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (rightNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (rightNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You got it! ");
            }
        }
    }
}
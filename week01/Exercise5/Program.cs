using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)

    //Functions
    {
        DisplayWelcome();

        string name = PromptUserName();

        int usernumber = PromptUserNumber();

        int Squarenumber = SquareNumber(usernumber);

        DisplayResult(name, Squarenumber);

    }

    static void DisplayWelcome()

    {
        Console.WriteLine("Welcome to the Program. ");
    }

    static string PromptUserName()

    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()

    {
        Console.Write("Please enter your favourite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int usernumber)

    { 
        int square = usernumber * usernumber;

        return square;
    }

    static void DisplayResult(String name, int square)

    {
    Console.WriteLine($"{name}, The square of your number is: {square}");
    }
    
}
using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string username = promptusername();
        int usernumber = promptusernumber();
        int squared = squarednumber(usernumber);
        DisplayResult(username, squared);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string promptusername()
    {
        Console.WriteLine("Plese enter your name");
        string name = Console.ReadLine();
        return name;
    }
    static int promptusernumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int squarednumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
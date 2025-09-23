using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number.");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static void PromptBirthYear(out int year)
    {
        Console.WriteLine("Please enter the year you were born.");
        year = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(string name, int squared, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        Console.WriteLine($"{name}, the square of your number is {squared}.");
        Console.WriteLine($"{name}, you will turn {age} years old this year.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        PromptBirthYear(out int birthYear);
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber, birthYear);
    
}
}
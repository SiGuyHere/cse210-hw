using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?(0-100)");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (grade%10 >= 7 && letter != "F" && letter != "A")
        {
            letter += "+";
        }
        else if (grade%10 < 3 && letter != "F")
        {
            letter += "-";
        }
        Console.WriteLine($"Your letter grade is: {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }

    }
}
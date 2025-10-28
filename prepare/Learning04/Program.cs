using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment thing = new MathAssignment("Silas Riday", "Fractions", "Chapter 4", "30-39");
        Console.WriteLine(thing.GetSummary());
        Console.WriteLine(thing.GetHomeworkList());
        WritingAssignment thing2 = new WritingAssignment("Silas Riday", "History", "The super bloody war");
        Console.WriteLine(thing2.GetSummary());
        Console.WriteLine(thing2.GetWritingInformation());
    }
}
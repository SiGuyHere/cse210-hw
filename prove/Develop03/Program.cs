using System;
using System.Collections.Concurrent;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the book?");
        string book = Console.ReadLine();
        Console.WriteLine("What is the chapter?");
        string chapter = Console.ReadLine();
        Console.WriteLine("What is the start verse?");
        string startVerseInput = Console.ReadLine();
        int startVerse = int.Parse(startVerseInput);
        Console.WriteLine("What is the end verse(type 'none' if there is none)?");
        string endVerseInput = Console.ReadLine();
        Reference reference;
        if (endVerseInput == "none")
        {
            reference = new Reference(book, chapter, startVerse);
        }
        else
        {
            int endVerse = int.Parse(endVerseInput);
            reference = new Reference(book, chapter, startVerse, endVerse);
        }
        Console.WriteLine("What is the text? ");
        string text = Console.ReadLine();
        Scripture.WordListCreator(text);
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("\nType 'quit' to finish, and 'help' to show 3 random words that were hidden.\nOtherwise hit enter to hide more lines.");
            reference.Display();
            Scripture.Display();
            Console.WriteLine("");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                keepRunning = false;
            } else if (input == "help")
            {
                Scripture.WordShow();
            } else
            {
                keepRunning = Scripture.WordHider();
            }
            Console.Clear();
            reference.Display();
            Scripture.Display();

        }
    }
}
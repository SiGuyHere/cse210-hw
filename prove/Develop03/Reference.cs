using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;

class Reference
{
    private string Book;
    private string Chapter;
    private int StartVerse;
    private int EndVerse;

    public Reference(string book, string chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
    }
    public Reference(string book, string chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }
    public void Display()
    {
        if (EndVerse == 0)
        {
            Console.WriteLine($"{Book} Chapter {Chapter} Verse {StartVerse}");
        }
        else
        {
            Console.WriteLine($"{Book} Chapter {Chapter} Verses {StartVerse}-{EndVerse}");
        }
        
    }

}
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;

class Reference
{
    private string _book;
    private string _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, string chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }
    public Reference(string book, string chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public void Display()
    {
        if (_endVerse == 0)
        {
            Console.WriteLine($"{_book} Chapter {_chapter} Verse {_startVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} Chapter {_chapter} Verses {_startVerse}-{_endVerse}");
        }
        
    }

}
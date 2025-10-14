using System;
public class Entry
{
    public static string CreateEntry(string userInput, string prompt)
    {
        DateTime date = DateTime.Today;
        string currentDate = date.ToShortDateString();
        return $"{currentDate}\n{prompt}\n{userInput}";
    }
}
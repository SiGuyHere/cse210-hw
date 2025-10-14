using System;
public class Entry
{
    private static string emptyString = " ";
    public static string entry
    {
        get { return emptyString; }
        set { emptyString = value; }
    }
    public static void CreateEntry(string userInput, string prompt)
    {
        DateTime date = DateTime.Today;
        string currentDate = date.ToShortDateString();
        entry = $"{currentDate}\n{prompt}\n{userInput}";
    }
}
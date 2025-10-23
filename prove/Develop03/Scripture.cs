

using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Scripture
{

    private static List<Word> wordText = new List<Word>();
    private static List<string> cleanWordText = new List<string>();
    public static void WordListCreator(string text)
    {
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word wordObject = new Word(word);
            wordText.Add(wordObject);
            cleanWordText.Add(word);
        }
    }
    public static bool WordHider()
    {
        Random random = new Random();
        int c = 0;
        bool end = true;
        while (c < 3)
        {
            end = false;
            int randomWord = random.Next(wordText.Count);
            if (!wordText[randomWord].Hidden)
            {
                wordText[randomWord].Hide();
                c = c + 1;
            }
            for (int i = 0; i < wordText.Count(); i++)
            {
                if (!wordText[i].Hidden)
                {
                    end = true;
                }
            }
            if (end == false)
            {
                return end;
            }

        }
        return end;
    }
    public static void WordShow()
    {
        Random random = new Random();
        int c = 0;
        while (c < 3)
        {
            bool end = false;
            int randomWord = random.Next(wordText.Count);
            if (wordText[randomWord].Hidden)
            {
                wordText[randomWord].Show(cleanWordText[randomWord]);
                c = c + 1;
            }
            for (int i = 0; i < wordText.Count(); i++)
            {
                if (wordText[i].Hidden)
                {
                    end = true;
                }
            }
            if (end == false)
            {
                c = 3;
            }
        }
    }
    public static void Display()
    {
        List<string> finalText = new List<string>();
        for (int i = 0; i < wordText.Count(); i++)
        {
            finalText.Add(wordText[i].WordText);
        }
        string result = string.Join(" ", finalText);
        Console.WriteLine($"\n{result}");
    }
}
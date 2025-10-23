using System.Text.RegularExpressions;
class Word
{
    public string WordText { get; set; }
    public bool Hidden { get; set; }
    public Word(string wordText)
    {
        WordText = wordText;
        Hidden = false;
    }
    public void Hide()
    {
        string pattern = "[^.,1234567890]";
        string replacement = "_";
        WordText = Regex.Replace(WordText, pattern, replacement);
        Hidden = true;
    }
    public void Show(string text)
    {
        WordText = WordText.Replace(WordText, text);
        Hidden = false;
    }
}
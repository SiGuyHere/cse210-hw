using System.Text.RegularExpressions;
class Word
{
    public string _wordText { get; set; }
    public bool _hidden { get; set; }
    public Word(string wordText)
    {
        _wordText = wordText;
        _hidden = false;
    }
    public void Hide()
    {
        string pattern = "[^.,1234567890]";
        string replacement = "_";
        _wordText = Regex.Replace(_wordText, pattern, replacement);
        _hidden = true;
    }
    public void Show(string text)
    {
        _wordText = _wordText.Replace(_wordText, text);
        _hidden = false;
    }
}
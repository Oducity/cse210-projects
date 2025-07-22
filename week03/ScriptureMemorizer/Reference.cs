public class Reference
{
    //The Reference class should contain its onw diplay
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    //private int _endVerse;

    public Reference(string book, int chapter, int startVerse) // Object constructor with all four attributes assigned.
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) // Object constructor with all four attributes assigned.
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        string book = _book;
        string chapter = _chapter.ToString();
        string verse = _verse.ToString();
        return $"{book} {chapter}: {verse} ";
    }
}
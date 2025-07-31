public class Reference
{
    private string _scriptureReference;
    private string _book;
    private int _chapter;
    private int _verse;
    

    public Reference(string book, int chapter, int startVerse) // Object constructor with all four attributes assigned.
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
    }

    public string GetReference()
    {
        string book = _book;
        string chapter = _chapter.ToString();
        string verse = _verse.ToString();
        Console.WriteLine($"{_book} {_chapter}: {_verse}; ");
        return $"{book} {chapter}: {verse} ";
    }

}
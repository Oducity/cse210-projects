public class Reference
{
    private string _scriptureReference;
    private string _book;
    private int _chapter;
    private int _verse;
    //private int _endVerse;
    
    //private List<string>  _reference = new List<string>{ "Alma, 2, 33", "John, 15, 4", "2 Nephi, 2, 2", "1 Cor, 15, 29", "Moses, 6, 65"};

    public Reference(string book, int chapter, int startVerse) // Object constructor with all four attributes assigned.
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
    }


    //public Reference() // Object constructor with all four attributes assigned.
    //{
        //_book = book;
        //_chapter = //int.Parse(chapter);
        //`_verse = //int.Parse(startVerse);
        //_endVerse = endVerse;
    //}

    public string GetReference()
    {
        string book = _book;
        string chapter = _chapter.ToString();
        string verse = _verse.ToString();
        Console.WriteLine($"{_book} {_chapter}: {_verse}; ");
        return $"{book} {chapter}: {verse} ";
    }

    public void SetReference()
    {
        //_scriptureReference = GetRandomReference();
    }

    //public string GetGeneratedReference()
    //{
    //    SetReference();
    //    Console.WriteLine(_scriptureReference);
    //    return _scriptureReference;
    //}
    // Exceed requirement codes
    //public void GetRandomReference()
    //{
        //Random rand = new Random();
        //string randItem = _reference[rand.Next(0, _reference.Length)];
        //return randItem;
        //Console.WriteLine(randItem);
    //}
}
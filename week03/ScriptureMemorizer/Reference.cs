class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _verse = -1; // Indicates a chapter-only reference
        _endVerse = -1; // Indicates a single verse reference
    }

    public Reference(string book, int chapter, int verse, int endVerse = -1)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_verse == -1)
        {
            return $"{_book} {_chapter}";
        }
        else if (_endVerse == -1 || _endVerse == _verse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
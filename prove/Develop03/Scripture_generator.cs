public class Scripture_genereator
{   
    private string _chapter = "";
    private string _verse;
    private string _verse2;

    
    public Scripture_genereator()
    {
        _chapter = "Proverbs 3:5-6";
        _verse = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        _verse2 = "In all thy ways acknowledge him, and he shall direct thy paths.";
    }
    public Scripture_genereator(string verse, string verse2)
    {
        _chapter = "Proverbs 3:5-6";
        _verse = verse;
        _verse2 = verse2;
    }

    public string GetChapter()
    {
        return _chapter;
    }
    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }
        public string GetVerse()
    {
        return _verse;
    }
    public void SetVerse(string verse)
    {
        _verse = verse;
    }
        public string GetVerse2()
    {
        return _verse2;
    }
    public void SetVerse2(string verse2)
    {
        _verse2 = verse2;
    }
    public string GetScripture(){
        return _verse +" "+ _verse2;
    }
}
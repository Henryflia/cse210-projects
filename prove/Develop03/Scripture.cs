public class Scripture 
{
    public List<string> _words = new List<string>();
    public void CopyScripture()
    {
    Scripture_genereator scriptureg = new Scripture_genereator();
    scriptureg.GetScripture();
    string x = scriptureg.GetScripture();
    string[] scripsplit = x.Split(" ");
    foreach (string y in scripsplit)
    {
        _words.Add(y);
    }
    }
    public List<string> SendTheList()
    {
        return _words;
    }
    // public void DisplayTList()
    // {
    //     foreach(string words in _words){
    //         Console.Write($"{words} ");
    //     }
    //     Console.ReadLine();
    // }

}
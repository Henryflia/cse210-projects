using System.IO; 

public class Journal
{
    public void SaveEntriesToFile(List<string> entries)
    {
        Console.Write("What is the name of the file?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string entry in entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
    public List<string> LoadEntriesFromFile(string fileName)
    {
        List<string> entries = new List<string>();
        using (StreamReader inputFile = new StreamReader(fileName))
        {
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                entries.Add(line);
            }
        }
        return entries;
    }
}

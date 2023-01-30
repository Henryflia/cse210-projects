public class Entry
{
    public List<string> _entrys = new List<string>();
    public void DisplayPrompt()
    {
        Console.WriteLine("What is your mood today?");
        string mood = Console.ReadLine();
        Promp_Developer prompte = new Promp_Developer();
        prompte.ListPrompt();
        string x = prompte.RandomPrompt();
        Console.WriteLine(x);
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _entrys.Add(dateText);
        _entrys.Add(mood);
        _entrys.Add(x);
       
  
    }
    public string UserEntry()
    {
        string userE = Console.ReadLine();
        return userE;
    }
    public void DisplayLIst()
    {
        Console.WriteLine("Lista de Entradas:");
        for (int i = 0; i < _entrys.Count; i++)
        {
            Console.WriteLine(_entrys[i]);
        }
    }    
    public void DisplyLit()
    {
        Console.Write(_entrys);
    }

}
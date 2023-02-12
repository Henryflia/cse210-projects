using System;

class Program
{
    static void Main(string[] args)
    {
        string endprogram = "";
        Scripture_genereator chapter = new Scripture_genereator();
        Words w1 = new Words();
            Console.Clear();
            Console.Write($"{chapter.GetChapter()} ");
            w1.GetScripture();
        while(endprogram != "quit")
        {   
            
            Console.Write($"{chapter.GetChapter()} ");
            w1.HideWords();
            w1.HideWords();
            w1.HideWords();
            w1.DisplayList();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            endprogram = Console.ReadLine();
        }
    }
}
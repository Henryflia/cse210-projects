using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        string choice = "0";
        while(choice!= "5")
        {
            Console.WriteLine("Please select one of the followiong choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if(choice == "1")
            {
                entry.DisplayPrompt();
                string response = entry.UserEntry();
                entry._entrys.Add(response);
            }
            else if(choice == "2")
            {
                entry.DisplayLIst();
                Journal journal = new Journal();
        
            }
            else if(choice == "3")
            {
                Console.Write("What is the name of the file to load?");
                string fileName = Console.ReadLine();
                Journal journal = new Journal();
                entry._entrys = journal.LoadEntriesFromFile(fileName);
            }
            else if(choice == "4")
            {
                    Journal journal = new Journal();
                    journal.SaveEntriesToFile(entry._entrys);
            }
            else if(choice == "5")
            {
                break;
            }

        }
    }
}
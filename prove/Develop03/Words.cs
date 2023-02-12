public class Words
{   
    private string _hiddenWord = "";
    public List<string> _wordList;
    Scripture list = new Scripture();
    public void GetScripture(){
        list.CopyScripture();
        var word = list.SendTheList();
        foreach(string wor in word)
        {
            Console.Write($"{wor} ");
        }
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        var endprogram = Console.ReadLine();
    }
    public void HideWords()
    {
        
        // list.SendTheList();
        var wordList = list.SendTheList();

        Random random = new Random();

            int random1 = random.Next(0, wordList.Count);
            for (int i = 0; i < wordList[random1].Length; i++)
            {
                _hiddenWord += "_";
            }
            
            wordList[random1] = _hiddenWord;
            _hiddenWord = "";
            _wordList = wordList;
        
        
    }
    public List<string> GetTheHList()
    {
        return _wordList;
    }
    
    public void DisplayList(){
        Console.WriteLine(_wordList);
        Console.Clear();
        if (_wordList == null)
            {
                Console.WriteLine("Error: word list is null");
                return;
            }

        else{
            Scripture_genereator chapter = new Scripture_genereator();
            Console.Write($"{chapter.GetChapter()} ");
            foreach(string m in _wordList)
            {
                Console.Write($"{m} ");
                if (AreAllWordsUnderscores(_wordList))
                {
                    Console.Clear();
                    Environment.Exit(0);

                }
            }

            // AreAllWordsUnderscores(_wordList);
        }
    }
    public bool AreAllWordsUnderscores(List<string> words)
        {
            bool allWordsAreUnderscores = true;

            foreach (string word in words)
            {
                bool allUnderscores = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] != '_')
                    {
                        allUnderscores = false;
                        break;
                    }
                }

                if (!allUnderscores)
                {
                    allWordsAreUnderscores = false;
                    break;
                }
            }

            return allWordsAreUnderscores;
        }
    }


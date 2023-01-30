public class Promp_Developer
{
    public List<string> _prompts = new List<string>();
    
    public void ListPrompt()
    {
        _prompts.Add("who did you meet?") ;
        _prompts.Add("What did you learn from your personal study of the gospel today?");
        _prompts.Add("If there was one thing you wanted to do again today, what would it be?");
        _prompts.Add("What did you do for your physical well-being today?");
        _prompts.Add("What emotions did you feel today?");
    }
    public string RandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNum = randomGenerator.Next(0, _prompts.Count-1);
        return _prompts[randomNum];
    }
    

}
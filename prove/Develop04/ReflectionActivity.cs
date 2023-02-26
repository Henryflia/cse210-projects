public class ReflectionActivity : Activity{
    private List<string> _prompt;
    private List<string> _questions;

    public ReflectionActivity(string activityname, string description) : base(activityname, description){
        _prompt = new List<string>{"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
        _questions = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    }
    public void RunPrompt(){
        Random randomGenerator = new Random();
        int randomNum = randomGenerator.Next(0, _prompt.Count-1);
        Console.WriteLine("Consider the following prompt:");
        string empty = Environment.NewLine;
        Console.WriteLine($"--- {_prompt[randomNum]} ---");
        Console.WriteLine(" ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine(" ");
    }
    public void ShowQuestions(int count){
        int countr = count;
        while(countr != 0 || countr < 0)
        {
            Random randomGenerator = new Random();
            int randomNum = randomGenerator.Next(0, _questions.Count-1);
            Console.WriteLine(_questions[randomNum]);
            countr -= 5;
            runSpinner();
            countr -= 5;
            runSpinner();
            countr -= 5;
            if(countr < 0){
                break;
            }

        }
    }
}
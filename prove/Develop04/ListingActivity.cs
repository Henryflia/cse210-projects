public class ListingActivity : Activity{
    private List<string> _prompts;

    public ListingActivity(string activityname, string description) : base(activityname, description){
    
        _prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};    

    }

    public void DisplayPrompts(){
        Random randomGenerator = new Random();
        int randomNum = randomGenerator.Next(0, _prompts.Count-1);
        Console.WriteLine("List as many resposes you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[randomNum]} ---");
        Console.WriteLine("You may begin in ");
        Console.Write("");

        for (int i = 5; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
    }

    public void EnterAnswer(int count){
        int countl = count;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(countl);
        int times = 0;
        while (DateTime.Now < endTime)
            {
                Console.Write(">");
                Console.ReadLine();
                times += 1;
            }
        Console.WriteLine($"You listed {times} items");
    }

}
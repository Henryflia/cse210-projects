public class Activity{
    private int _countdown;

    private string _description = "";
    private string _activityname = "";
    
    List<string> animationlist = new List<string>();
    public Activity()
    {
        _countdown = 0;
        _activityname = "Non";
        _description = "Non";
    }

    public Activity(string activityname, string description)
    {
        _activityname = activityname;
        _description = description;
    }
    public void RunActivity(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityname} Activity");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
    }
    public void StartMessage(){
        Console.Clear();
        Console.WriteLine("Get Ready");
        runSpinner();
        Console.WriteLine("");
    }
    public int GetCountDown(){
        Console.Write("How long, in seconds, would you like for your session? ");
        int usercount = int.Parse(Console.ReadLine()); 
        _countdown = usercount;
        return _countdown;
    }
    public void runSpinner(){

            animationlist.Add("|");
            animationlist.Add("\\");
            animationlist.Add("-");
            animationlist.Add("/");
            animationlist.Add("|");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(5);

            int i = 0;

            while (DateTime.Now < endTime)
            {
                string s = animationlist[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i++;
                if (i > animationlist.Count)
                {
                    i = 0;
                }
            }
        }
    public void RunCoundown()
    {
            int cd = _countdown;
            for (int i = 5; i > 0; i--){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                }
            _countdown -= 5;
            if(_countdown == 0)
            {
                string p = Environment.NewLine;           
            }
    }
    public void DisplayEndMessage(int time){
        Console.WriteLine("Well Done!!!");
        runSpinner();
        Console.WriteLine($"You have completed another {time} seconds of the {_activityname} Activity.");
        runSpinner();
    }
    public int GetTime(){
        int time = _countdown;
        return time;
    }
}

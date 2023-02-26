public class BreathingActivity : Activity
{
    private string _breathin = "";
    private string _breathout = "";

    public BreathingActivity(string breathin, string breathout, string activityname, string description) : base(activityname, description){
        _breathin = breathin;
        _breathout = breathout;
    }
    private void Breathin(){
        Console.Write(_breathin);
        RunCoundown();
        Console.WriteLine();
    }
    private void Breathout(){
        Console.Write(_breathout);
        RunCoundown();
        Console.WriteLine();
       
    }
    public void DisplaytheBreathing(int count){
        int count2 = count;
        int i = 0;
        while(i != count2 || i !> count2)
        {
            Breathin();
            count2 -= 5;
            Breathout();
            count2 -= 5;
        }
            

    }

    
}

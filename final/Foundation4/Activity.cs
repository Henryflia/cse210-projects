public class Activity{
    private string _date = "";
    private int _length = 0;
    private string _type = "";
    List<string> _summary = new List<string>(); 
    public Activity(string date, int length, string type){
        _date = date;
        _length = length;
        _type = type;
    }
    public int GetLength(){
        return _length;
    }
    public string GetDate(){
        return _date;
    }
    public string GetTypeofEvent(){
        return _type;
    }
    public virtual double GetDistance(){
        return 0.0;
    } 
    public virtual double GetSpeed(){
        return 0.0;

    }
    public virtual double GetPace(){
        return 0.0;

    }
    public void GetSummary(){
        foreach(string n in _summary){
            string[] b = n.Split(",");
            string s = $"{b[0]} {b[1]} ({b[2]} min)- Distance {b[3]} km, Speed {b[4]} kph, Pace: {b[5]} min per km";
            Console.WriteLine(s);
        }
    }
    public virtual void SaveInTheList(string s){
        _summary.Add(s);
    }

}
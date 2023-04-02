public class Running : Activity{
    private double _distance = 0;
    public Running(double distance, string date, int length, string type) : base(date, length, type){
        _distance = distance;
    }
    public override double GetDistance(){
        return Math.Round(_distance, 1);
    }
    public override double GetSpeed(){
        return Math.Round(GetDistance() / GetLength() * 60, 1);
    }
    public override double GetPace(){
        return Math.Round(GetLength() / GetDistance(), 1);
    }
    public string StringList()
    {
        return $"{GetDate()},{GetType()},{GetLength()},{GetDistance()},{GetSpeed()},{GetPace()}";
    }
}
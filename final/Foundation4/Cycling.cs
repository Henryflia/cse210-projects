public class Cycling : Activity{
    private double _speed = 0;
    public Cycling(string date, double speed, int length, string type) : base(date, length, type){
        _speed = speed;
    }

    public override double GetDistance(){
        return Math.Round(GetSpeed() / 60 * GetLength(), 1);
    }
    public override double GetSpeed(){
        return Math.Round(_speed, 1);
    }
    public override double GetPace(){
        return Math.Round(GetLength() / GetDistance(), 1);
    }
    public string StringList()
    {
        return $"{GetDate()},{GetType()},{GetLength()},{GetDistance()},{GetSpeed()},{GetPace()}";
    }
}
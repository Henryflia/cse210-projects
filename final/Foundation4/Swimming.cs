public class Swimming : Activity{
    private int _laps = 0;
    public Swimming(int lap, string date, int length, string type) : base(date, length, type){
        _laps = lap;
    }

    public override double GetDistance(){
        return Math.Round(_laps * 50 / 1000.0, 2);
    }
    public override double GetSpeed(){
        double speed = GetDistance() / GetLength() * 60;
        return Math.Round(speed, 2);
    }
    public override double GetPace(){
        double pace = 60 / GetSpeed();
        return Math.Round(pace, 2);
    }
    public string StringList()
    {
        return $"{GetDate()},{GetType()},{GetLength()},{GetDistance()},{GetSpeed()},{GetPace()}";
    }
}
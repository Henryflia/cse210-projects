namespace eventplan{
public class Outdoor : Event
{
    private int _weather = 0;

    public Outdoor(int weather, string title, string description, string date, string time, Address address, string typeofevent, string details) : base(title, description, date, time, address, typeofevent, details){
        _weather = weather;
    }
    public int GetWeather(){
        return _weather;
    }
    public void DisplaytheEvent(){
        if(GetDetails() == "Standard"){
            StandardDetails(GetTitle(), GetDescription(), GetDate(), GetTime(), GetAddress());
        }  
        else if(GetDetails() == "Full"){
                Console.WriteLine($"Event Title:{GetTitle()}");
                Console.WriteLine($"Description: {GetDescription()}");
                Console.WriteLine($"Weather: {GetWeather()}");
                Console.WriteLine($"Date: {GetDate()}");
                Console.WriteLine($"Time: {GetTime()}");
                Console.WriteLine($"Address: {GetAddress()}");
            }
        else if(GetDetails() == "Short"){
            ShortDetails(GetTypeofEvent(), GetTitle(), GetDate());
        }
    }


}
}
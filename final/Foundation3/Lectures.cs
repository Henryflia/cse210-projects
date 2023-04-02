namespace eventplan{
public class Lectures : Event{
    private string _speaker = "";
    private string _capacity = "";
    
    public Lectures(string speaker, string capacity, string title, string description, string date, string time, Address address, string typeofevent, string details) : base(title, description, date, time, address, typeofevent, details){
        _speaker = speaker;
        _capacity = capacity;
    }
    
    public string GetSpeaker(){
        return _speaker;
    }
    public string GetCapacity(){
        return _capacity;
    }
    public void DisplaytheEvent(){
        if(GetDetails() == "Standard"){
            StandardDetails(GetTitle(), GetDescription(), GetDate(), GetTime(), GetAddress());
        }  
        else if(GetDetails() == "Full"){

                Console.WriteLine($"Event Title: {GetTitle()}");
                Console.WriteLine($"Description: {GetDescription()}");
                Console.WriteLine($"Speaker: {GetSpeaker()}");
                Console.WriteLine($"Capacity: {GetCapacity()}");
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
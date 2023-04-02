namespace eventplan{
public class Event{
    private string _title = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private Address _address;
    private string _typeofevent = "";
    private string _details = "";
    public Event(string title, string description, string date, string time, Address address, string typeofevent, string details){
        _title = title; 
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _typeofevent = typeofevent;
        _details = details;
    }
    public string GetTitle(){
        return _title;
    }
    public string GetDescription(){
        return _description;
    }

    public string GetDate(){
        return _date;
    }
    public string GetTime(){
        return _time;
    }
    public string GetDetails(){
        return _details;
    }
    public string GetAddress(){
        Console.WriteLine( _address.GetTheAddress().ToString());
       return _address.GetTheAddress().ToString();
    }
    public string GetTypeofEvent(){
        return _typeofevent;
    }

    public void StandardDetails(string title, string description, string date, string time, string address){
        Console.WriteLine($"Event Title: {title}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Time: {time}");
        Console.WriteLine($"Address: {address}");
    }
    public void ShortDetails(string typeofevent,string title, string date){
        Console.WriteLine($"Event Type:{typeofevent}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Date: {date}");
    }
}
}
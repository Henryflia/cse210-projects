namespace eventplan{
public class Receptions : Event
{
    private string _emailRSVP = "";

    
    public Receptions(string emailRSVP, string title, string description, string date, string time, Address address, string typeofevent, string details) : base(title, description, date, time, address, typeofevent, details){
        _emailRSVP = emailRSVP;
    }

    public string GetEmail(){
        return _emailRSVP;
    }
    public void DisplaytheEvent(){
        if(GetDetails() == "Standard"){
            string v = GetAddress();
            string s = v.ToString();
            StandardDetails(GetTitle(), GetDescription(), GetDate(), GetTime(), s);
        }  
        else if(GetDetails() == "Full"){
                Console.WriteLine($"Event Title: {GetTitle()}");
                Console.WriteLine($"Description: {GetDescription()}");
                Console.WriteLine($"Email for Reception: {GetEmail()}");
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
public class Address{

    private string _streetaddress = "";
    private string _city = "";
    private string _stateprovince = "";
    private string _country = "";

    public Address(string streetaddress, string city, string stateprovince, string country){
        _streetaddress = streetaddress;
        _city = city;
        _stateprovince = stateprovince;
        _country = country;
    }
    public string GetCountry(){
        return _country;
    }
    public bool ConfirmCountry(){
        string country = GetCountry();
        if(country.ToUpper() == "USA"){
            return true;
        }
        else
            return false;

    }
    public string GetInformationAddress(){
        return $"{_country}, {_stateprovince}, {_city}, {_streetaddress}";
    }
}

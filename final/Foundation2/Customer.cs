public class Customer{
    public string _customername = "";
    public Address _address;

    public Customer(){
        _customername = "";
    }

    public Customer(string customername, Address address){
        _customername = customername;
        _address = address;
    }
    public string GetCustomer(){
        return _customername;
    }
    public string GetAddress(){
        string address = _address.GetInformationAddress();
        string[] addr = address.Split(",");
        return $"{addr[3]}, {addr[2]}, {addr[1]}, {addr[0]}";
    }
    public bool GetBoolAddress(){
        return _address.ConfirmCountry();
    }

}
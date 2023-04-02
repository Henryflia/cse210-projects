namespace eventplan{

public class Address{
    private string _address = "";

    public Address (string address){
        _address = address;
    }
    public string GetTheAddress(){
        return _address;
    }
}
}
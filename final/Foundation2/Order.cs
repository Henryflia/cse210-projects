public class Order{
    private string _customername;
    private int _totalprice = 0;
    private List<string> _products = new List<string>();
    
    public Order(string customer){
        _customername = customer;
    }

    public void AddtoTheList(Product m){
        string v = $"{m.Getname()},{m.GetProductid()},{m.Getprice()},{m.GetQuantity()},{m.PriceProduct()}";
        _products.Add(v);
        // foreach(string n in _products){
        //     Console.WriteLine(n);
        // }
      
    }
    public void TotalPrice(Address p){
        _totalprice = 0;
        foreach(string n in _products){
            string[] b = n.Split(",");
            _totalprice += int.Parse(b[4]);
        }
        if(p.ConfirmCountry() == true){
            _totalprice += 5;
        }
        else{
            _totalprice += 35;
        }
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${_totalprice}");
    }
    public void ShippingLabel(Customer customerinf){
        Console.WriteLine($"Name: {customerinf.GetCustomer()}");
        Console.WriteLine($"Address: {customerinf.GetAddress()}");
    }
    public void PakingLabel(){
        Console.WriteLine($"Products List:");
        int num = 1;
        foreach(string prod in _products){
            string[] splitprod = prod.Split(",");
            Console.WriteLine($"{num}. Name: {splitprod[0]} ID: {splitprod[1]}");
            num += 1;
        }
    }

}
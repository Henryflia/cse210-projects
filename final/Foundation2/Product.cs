public class Product{

    private string _name = "";
    private string _productid = "";
    private int _price;
    private int _quantity;

    public Product(){
        _name = "";
        _productid = "";
        _price = 0;
        _quantity = 0;
    }

    public Product(string name, string productid, int price, int quantity){
        _name = name;
        _productid = productid;
        _price = price;
        _quantity = quantity;
    }
    public string Getname(){
        return _name;
    }
    public string GetProductid(){
        return _productid;
    }
    public int Getprice(){
        return _price;
    }
    public int GetQuantity(){
        return _quantity;
    }
    public int PriceProduct(){
        int price = Getprice();
        int quantity = GetQuantity();
        int total = price * quantity;
        return total;
    }
    public string GetProductInformation(){
        return $"{_name},{_productid},{_price},{_quantity},{PriceProduct()})";
    }
}   
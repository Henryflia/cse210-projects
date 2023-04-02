using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Apple","23412412412",200,3);
        Product product2 = new Product("Banana","23412422637",100,2);
        Address address1 = new Address("Street 4", "La Romana", "Romana", "Rep.Dom");
        Customer customer1 = new Customer("Juan", address1);
        Order order1 = new Order(customer1.GetCustomer());
        order1.AddtoTheList(product1);
        order1.AddtoTheList(product2);
        order1.TotalPrice(address1);
        order1.PakingLabel();
        order1.ShippingLabel(customer1);
        Console.WriteLine("---------------------------------");
        Product product3 = new Product("Pencil","23412454574",30,3);
        Product product4 = new Product("Book","23415665752",200,2);
        Address address2 = new Address("Smith 30", "Idaho", "Utah", "USA");
        Customer customer2 = new Customer("Richard", address2);
        Order order2 = new Order(customer1.GetCustomer());
        order2.AddtoTheList(product3);
        order2.AddtoTheList(product4);
        order2.TotalPrice(address2);
        order2.PakingLabel();
        order2.ShippingLabel(customer2);

    }
}
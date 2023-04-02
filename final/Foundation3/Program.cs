using System;
 namespace eventplan{
class Program
{
    static void Main(string[] args)
    {
        Address lecturea = new Address("Street 5, HIGUEY, c Canada");
        Lectures lecture = new Lectures("Ester","11","Mañana", "Pantalosnes", "3/30/2021", "12:00", lecturea,"Lectures", "Standard");
        Console.WriteLine("-----------------------");
        lecture.DisplaytheEvent();
        Console.WriteLine("-----------------------");
        Address receptiona = new Address("Street Home, Finish, All");
        Receptions reception = new Receptions("event@gmail.com","Mañana", "Pantalosnes", "3/30/2021", "12:00", receptiona,"Reception Event", "Full");
        Console.WriteLine("-----------------------");
        reception.DisplaytheEvent();
        Console.WriteLine("-----------------------");
        Address outdoora = new Address("Street Silence, No, Anything");
        Outdoor outdoor = new Outdoor(35,"Mañana", "Pantalosnes", "3/30/2021", "12:00", outdoora,"Outdoor Event", "Short");
        Console.WriteLine("-----------------------");
        outdoor.DisplaytheEvent();
        Console.WriteLine("-----------------------");
    
}
}
}
using AM.ApplicationCore.Domaine;


internal class Program
{
    private static void Main(string[] args)
    {
       
        Plane p = new Plane();
        ICollection<Flight> f = new List<Flight>();
        p.Capacity = 100;
        p.ManufactureDate= DateTime.Now;
        p.PlaneId = " KC-767";
        p.PlaneType = PlaneType.Boing;
        p.Flights= f;
        Console.WriteLine(p);
      //  Plane p1= new Plane(PlaneType.Airbus,200,DateTime.Now);
      // Console.WriteLine(p1);
        
        Plane p2 = new Plane() { Capacity = 400, ManufactureDate = DateTime.Now, PlaneId = "1234", PlaneType=PlaneType.Airbus, Flights = f };
        Console.WriteLine(p2);
     
        
        

    }
}
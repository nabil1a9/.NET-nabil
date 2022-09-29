using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domaine
{ public enum PlaneType
    { Boing,
    Airbus}
    public class Plane
    {   
       
        public double Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public String PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "capacity = "+Capacity+ " ManufactureDate = "+ ManufactureDate+ " PlaneId = "+ PlaneId+ " PlaneType = "+ PlaneType+ " Flights ="+Flights.ToString();
        }
      /*  public Plane(PlaneType pt, int capacity, DateTime date)
        {
            this.Capacity = Capacity;
            this.ManufactureDate = date;
            this.PlaneType = pt;
        }
        public Plane() 
        { }
      */

    }
}

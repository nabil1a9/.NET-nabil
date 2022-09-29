using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domaine
{
    public class Flight
    {
        public String Destination { get; set; }
        public string Deparature { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime DateArrival { get; set; }
        public int EstimateDuration { get; set; }
        public virtual Plane Plane { get; set; }
        public virtual  ICollection<Passenger> Passengers { get; set; }
        public override string ToString()
        {
            return "Destination = "+ Destination+ " Deparature= "+ Deparature+ " FlightDate = "+ FlightDate+ " FlightId= "+ FlightId+ " DateArrival = "+ DateArrival+ " EstimateDuration= "+ EstimateDuration+ " Plane ="+ Plane.ToString()+ " Passenger= "+ Passengers.ToString();
        }

    }
}

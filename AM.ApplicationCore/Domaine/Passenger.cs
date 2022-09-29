using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domaine
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public String PasseportNumber { get; set; }
        public String EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "BirthDate = "+ BirthDate+ " PasseportNumber = "+ PasseportNumber+ " EmailAdress = "+ EmailAdress+ " FirstName = "+ FirstName+ " LastName = "+ LastName+ " TelNumber = "+ TelNumber+ " Flights = "+ Flights.ToString();
        }
    }
}

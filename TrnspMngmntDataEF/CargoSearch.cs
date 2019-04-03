using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrnspMngmntDataEF
{
    public class CargoSearch
    {
        public CargoSearch( Nullable<System.DateTime> departureDate, Nullable<System.DateTime> destinationDate,
            Nullable<System.TimeSpan> departureTime, Nullable<System.TimeSpan> destinationTime, string destinationCity,string departureCity,
            string destinationAdress,string departureAdress, Nullable<int> weight)
        {
            
            Weight = weight;
            DepartureDate = departureDate;
            DestinationDate = destinationDate;
            DepartureAdress = departureAdress;
            DestinationAdress = destinationAdress;
            DestinationCity = destinationCity;
            DepartureCity = departureCity;
            DepartureAdress = departureAdress;
            DestinationAdress = destinationAdress;
            DestinationTime = destinationTime;
            DepartureTime = departureTime;
        }

        public Nullable<System.DateTime> DepartureDate { get; set; }
        public Nullable<System.TimeSpan> DepartureTime { get; set; }
        public string DepartureCity { get; set; }
        public string DepartureAdress { get; set; }
        public Nullable<int> Weight { get; set; }  
        public Nullable<System.DateTime> DestinationDate { get; set; }
        public Nullable<System.TimeSpan> DestinationTime { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationAdress { get; set; }
    }
}

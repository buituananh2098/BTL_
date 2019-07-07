using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace QLLichBay.Model
{
    [Table("QLMayBay1.Routess")]
    public partial class Routess
    {
        public string RoutesID { get; set; }
        public string DepartureAirportsID { get; set; }
        public string ArrivalAirportsID { get; set; }
        public string Distance { get; set; }
        public decimal FlightTime { get; set; }

    }
}

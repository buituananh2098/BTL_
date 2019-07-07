using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace QLLichBay.Model
{
    [Table("QLMayBay1.Aircrafts")]
    public partial class Aircrafts
    {
        public string AircraftsID { get; set; }
        public string Name { get; set; }
        public string MakeModel { get; set; }
        public decimal TotalSeats { get; set; }
        public decimal EconomySeats { get; set; }
        public decimal BusinessSeats { get; set; }

    }
}

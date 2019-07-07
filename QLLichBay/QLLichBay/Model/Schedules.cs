using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace QLLichBay.Model
{
    [Table("QLMayBay1.Schedules")]
    public partial class Schedules
    {
        public decimal ID { get; set; }
        public DateTime DATE_ { get; set; }
        public DateTime TIME_ { get; set ; }
        public string FLIGHT_NUMBER { get; set; }
        public decimal ECONOMY_PRICE { get; set; }
        public decimal BUSINESS_PRICE { get; set; }
        public decimal FIRST_CLASS_PRICE { get; set; }
        public Byte CONFIRMED { get; set; }
        public decimal AIRSCRAFT_ID { get; set; }
        public decimal ROUTE_ID { get; set; }
    }
}

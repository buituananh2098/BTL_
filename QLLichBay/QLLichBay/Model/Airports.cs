using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace QLLichBay.Model
{
    [Table("QLMayBay1.Airports")]
    public partial class Airports
    {
        public decimal ID { get; set; }
        public string IATA_CODE { get; set; }
        public string NAME { get; set; }
        public decimal COUNTRY_ID { get; set; }

    }
}

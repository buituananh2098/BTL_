using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace QLLichBay.Model
{
    [Table("QLMayBay1.Countries")]
    public partial class Countries
    {
        public string CountriesID { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace QLLichBay.Model
{
    [Table("QLMayBay1.Offices")]
    public partial class Offices
    {
        public string OfficesID { get; set; }
        public string CountriesID { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
    }
}

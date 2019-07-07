using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace QLLichBay.Model
{
    [Table("QLMayBay1.Roles")]
    public partial class Roles
    {
        public string RolesID { get; set; }
        public string Title { get; set; }
    }
}

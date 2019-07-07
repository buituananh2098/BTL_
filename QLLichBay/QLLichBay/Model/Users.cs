using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace QLLichBay.Model
{
    [Table("QLMayBay1.Users")]
    public partial class Users
    {
        public string UsersID { get; set; }
        public string OfficesID { get; set; }
        public string RolesID { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Active { get; set; }
    }
}

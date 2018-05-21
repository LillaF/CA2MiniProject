using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA2MiniProject.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int MinsUsed { get; set; }
        public int ApplianceID { get; set; }

        public virtual ICollection<Appliance> Appliances { get; set; }
    }
}
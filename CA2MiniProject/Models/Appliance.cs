using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA2MiniProject.Models
{
    public class Appliance
    {
        public int ApplianceID { get; set; }
        public string EnergySrc { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }
        public int CostPerMin { get; set; }

 //       public virtual ICollection<User> Users { get; set; }
    }
}

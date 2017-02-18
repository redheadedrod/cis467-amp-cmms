using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Maintenance
{
    /// <summary>
    /// This class will list the different classifications of work orders (Preventitive Maintenence, Corrective Maintenence, Safety Maintenence)
    /// Id - Record ID
    /// Name - name of the actual type
    /// </summary>
    public class MaintenanceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
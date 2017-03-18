using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Maintenance
{
    /// <summary>
    /// Issue actually needing to be fixed
    /// Id - record id
    /// Name - actual issue related to the IssueClass (Example - for Pipe could be Leak, broken, install, repair/replace
    /// </summary>
    public class MaintenanceIssue
    {
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Maintenance
{
    /// <summary>
    /// Issue actually needing to be fixed
    /// Id - record id
    /// IssueClass - class of issue such as Pipe, Pump, Valve
    /// Name - actual issue related to the IssueClass (Example - for Pipe could be Leak, broken, install, repair/replace
    /// </summary>
    public class Issue
    {
        public int Id { get; set; } 
        public ClassOfIssue IssueClass { set; get; }
        public string Name { get; set; }
    }
}
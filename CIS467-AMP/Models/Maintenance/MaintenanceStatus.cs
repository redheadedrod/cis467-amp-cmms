using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Maintenance
{
    /// <summary>
    /// This keeps track of the status of a work order such as Waiting Approval, Waiting for Parts, In progress, Closed, Waiting to schedule, waiting for conditions etc
    /// Id - record Id
    /// Name - name of status
    /// </summary>
    public class MaintenanceStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
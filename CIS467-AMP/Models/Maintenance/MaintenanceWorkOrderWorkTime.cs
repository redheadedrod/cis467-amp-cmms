using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.Maintenance
{
    /// <summary>
    /// Time tracker for one worker on a work order for specific day. Have to add additional records for different days
    /// Id - record id
    /// Worker - link to Worker doing the work
    /// WorkerId - link to Worker doing the work - for forms
    /// StartTime - Date and time work was started
    /// HoursWorked - Hours worked in the day  (Can't be more than the time available for rest of day)
    /// MaintenanceWorkOrder =  link to related work order
    /// MaintenanceWorkOrderId =  link to related work order - for forms
    /// </summary>
    public class MaintenanceWorkOrderWorkTime
    {
        public int Id { get; set; }
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }
        public DateTime StartTime { get; set; }
        public float HoursWorked { get; set; }
        public MaintenanceWorkOrder MaintenanceWorkOrder { get; set; }
        public int MaintenanceWorkOrderId { get; set; }
    }
}
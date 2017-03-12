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
    /// WorkerId - Worker doing the work
    /// StartTime - Date and time work was started
    /// HoursWorked - Hours worked in the day  (Can't be more than the time available for rest of day)
    /// WorkOrderId = Id of work order relating this to
    /// </summary>
    public class WorkTime
    {
        public int Id { get; set; }
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }
        public DateTime StartTime { get; set; }
        public int HoursWorked { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public int WorkOrderId { get; set; }
    }
}
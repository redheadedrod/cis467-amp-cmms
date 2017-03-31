using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Please select Worker!")]
        public int WorkerId { get; set; }
        [Required(ErrorMessage = "Please select start date/time!")]
        public DateTime StartTime { get; set; }
        [Required(ErrorMessage = "Please enter how many hours worked!")]
        [Range(0.1,24, ErrorMessage = "Please enter number between 0.1 and 24")]
        public float HoursWorked { get; set; }
        public MaintenanceWorkOrder MaintenanceWorkOrder { get; set; }
        public int MaintenanceWorkOrderId { get; set; }
    }
}
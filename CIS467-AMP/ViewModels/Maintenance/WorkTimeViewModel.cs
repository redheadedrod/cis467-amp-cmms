using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Maintenance;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.ViewModels.Maintenance
{
    public class WorkTimeViewModel
    {
        public IEnumerable<MaintenanceWorkOrderWorkTime> MaintenanceWorkOrderWorkTimes { get; set; }
        public IEnumerable<Worker> Worker { get; set; }
       // public MaintenanceWorkOrder MaintenanceWorkOrder { get; set; }
        public MaintenanceWorkOrderWorkTime MaintenanceWorkOrderWorkTime { get; set; }
        public int Id { get; set; }
    }
}
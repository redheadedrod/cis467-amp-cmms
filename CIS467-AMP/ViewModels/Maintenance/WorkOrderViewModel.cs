using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Maintenance;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.ViewModels.Maintenance
{
    public class WorkOrderViewModel
    {
        
        public IEnumerable<Worker> Workers { get; set; }
        public IEnumerable<AssetInventory> AssetInventories { get; set; }
        public IEnumerable<MaintenanceStatus> MaintenanceStatuses { get; set; }
        public DbSet<MaintenanceIssue> MaintenanceIssue { get; set; }
        public DbSet<JobPlan> JobPlan { get; set; }
        public MaintenanceWorkOrder MaintenanceWorkOrder { get; set; }
        public int Priority { get; set; }
        public bool Edit { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS467_AMP.Models.Shared;

namespace CIS467_AMP.Models.Maintenance
{
    /// <summary>
    /// This is the main work order record class that contains the information about what a work order is
    /// Id - Record ID
    /// CreatorId - Worker that creaded the work order
    /// CreatedDateTime - Date and time the order was created
    /// StatusId - Status of work order
    /// LastStatusDateTime - last time the status was changed
    /// Priority - value from 1 - 10 for the value with 1 being highest value
    /// SupervisorId - id of the supervisor for the workers doing the job
    /// Leadworker - Worker assigned the job originally
    /// AssetId - Id of asset being worked on
    /// ShortDesc - short (80 chars) header describing work tobe done
    /// LongDesc - additional information about work to be done if necissary. 
    /// IssueId - Id of the type of issue this work order is addressing
    /// </summary>
    public class WorkOrder
    {
        //
        public int Id { get; set; }
        public Worker CreatorId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public MaintenanceStatus StatusId { get; set; }
        public DateTime LastStatusDateTime { get; set; }
        public int Priority { get; set; }
        public Worker SupervisorId { get; set; }
        public Worker LeadWorkerId { get; set; }
        public AssetInventory AssetId { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public JobPlan JobPlanId { get; set; }
        public Issue IssueId { get; set; }
    }
}
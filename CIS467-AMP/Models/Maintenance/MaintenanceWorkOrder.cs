using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// MaintenanceStatus - Link to Status of work order
    /// MaintenanceStatusId - Link to status of Work Order - For forms
    /// LastStatusDateTime - last time the status was changed
    /// Priority - value from 1 - 10 for the value with 1 being highest value
    /// Supervisor - id of the supervisor for the workers doing the job
    /// Supervisor - id of the supervisor for the workers doing the job - for forms
    /// Leadworker - link to Worker assigned the job originally
    /// LeadworkerId - link to Worker assigned the job originally - for forms
    /// AssetInventory - link to Id of asset being worked on
    /// AssetInventoryId - link to Id of asset being worked on - for forms
    /// ShortDesc - short (80 chars) header describing work tobe done
    /// LongDesc - additional information about work to be done if necissary. 
    /// JobPlan - Link to job plan if one is available
    /// JobPlanId - Link to job plan if one is available - for forms
    /// MaintenanceIssue - Link to the type of issue this work order is addressing
    /// MaintenanceIssueId - Link to the type of issue this work order is addressing - for forms
    /// </summary>
    public class MaintenanceWorkOrder
    {
        public int Id { get; set; }
        public Worker Creator { get; set; }
        public int CreatorId { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
        public DateTime CreatedDateTime { get; set; }
        public MaintenanceStatus MaintenanceStatus { get; set; }
        public int MaintenanceStatusId { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
        public DateTime LastStatusDateTime { get; set; }
        public int Priority { get; set; }
        public Worker Supervisor { get; set; }
        public int SupervisorId { get; set; }
        public Worker LeadWorker { get; set; }
        public int LeadWorkerId { get; set; }
        public AssetInventory AssetInventory { get; set; }
        public int AssetInventoryId { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public JobPlan JobPlan { get; set; }
        public int? JobPlanId { get; set; }
        public MaintenanceIssue MaintenanceIssue { get; set; }
        public int MaintenanceIssueId { get; set; }
    }
}
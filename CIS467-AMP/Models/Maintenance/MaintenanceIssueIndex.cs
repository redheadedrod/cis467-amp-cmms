using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.Maintenance
{
    /**
     * This is an index of issues for each class of index
     * Id - Record Id
     * MaintenanceClassOfIssue - link to Issue class
     * MaintenanceClassOfIssueId - link to Issue class - for forms
     * MaintenanceIssue - link to the actual issue (Done this way because multiple things can have same issue)
     * MaintenanceIssueId- link to actual issue - for forms
     */
    public class MaintenanceIssueIndex
    {
        public int Id { get; set; }
        public MaintenanceClassOfIssue MaintenanceClassOfIssue { get; set; }
        public int MaintenanceClassOfIssueId { get; set; }
        public MaintenanceIssue MaintenanceIssue { get; set; }
        public int MaintenanceIssueId { get; set; }
    }
}
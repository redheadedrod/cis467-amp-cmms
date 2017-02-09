using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Areas.Shared.Model
{
    /// <summary>
    /// List of workers
    /// 
    /// WorkerID is ID for entry
    /// WorkGroup is group worker belongs to
    /// Name - Full name of employee
    /// EmployeeID - Employer designated ID for employee
    /// PhoneNumber - contact number for employee
    /// EmailAddress - contact email for employee
    /// </summary>
    public class Worker
    {
        public int WorkerId { get; set; }
        public WorkGroup WorkGroupId { get; set; }
        public string Name { get; set; }
        public string EmployeeId { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
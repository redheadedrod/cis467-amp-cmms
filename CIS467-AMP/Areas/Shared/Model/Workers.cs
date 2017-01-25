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
    public class Workers
    {
        public int WorkerID { get; set; }
        public int WorkGroupID { get; set; }
        public string Name { get; set; }
        public string EmployeeID { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
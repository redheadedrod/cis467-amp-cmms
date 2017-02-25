namespace CIS467_AMP.Models.Shared
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
        public int Id { get; set; }
        public WorkGroup WorkGroup { get; set; }
        public string Name { get; set; }
        public string Employee { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
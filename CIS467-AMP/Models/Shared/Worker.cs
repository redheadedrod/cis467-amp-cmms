namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// List of workers
    /// 
    /// Id - Id for record
    /// WorkGroup - group worker belongs to
    /// WorkGroupId - group worker belongs to - used in forms
    /// Name - Full name of employee
    /// First name - First name of employee
    /// Last name - Last name of employee
    /// EmployeeID - Employer designated ID for employee
    /// PhoneNumber - contact number for employee
    /// EmailAddress - contact email for employee
    /// </summary>
    public class Worker
    {
        public int Id { get; set; }
        public WorkGroup WorkGroup { get; set; }
        public int WorkGroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string EmployeeId { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}

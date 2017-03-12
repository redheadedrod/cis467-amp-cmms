namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Job plan related documents - most of time should be one document but could be multiples
    /// 
    /// JobPlanDocsID - ID of entry
    /// JobPlanID - ID of jobplan related to
    /// Filename - Name of file for job plan
    /// </summary>
    public class JobPlanDocument
    {
        public int Id { get; set; }
        public JobPlan JobPlan { get; set; }
        public int JobPlanId { get; set; }
        public string Filename { get; set; } 
    }
}
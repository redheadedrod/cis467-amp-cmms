namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Job plan related documents - most of time should be one document but could be multiples
    /// 
    /// Id - Record Id
    /// JobPlan - Link to JobPlan this is linked to
    /// JobPlanId - Link to Jobplan this is linked to - used in forms
    /// FileName - Filename of Job plan document not including pathname
    /// </summary>
    public class JobPlanDocument
    {
        public int Id { get; set; }
        public JobPlan JobPlan { get; set; }
        public int JobPlanId { get; set; }
        public string Filename { get; set; } 
    }
}

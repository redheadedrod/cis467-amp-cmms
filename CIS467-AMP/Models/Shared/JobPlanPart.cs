namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Listing of parts for specific job plan
    /// 
    /// id - Record ID
    /// JobPlan - Link to Job plan
    /// JobPlanId - Link to Job plan - used in Forms
    /// ManufacturerPart - Link to Manufacturer part
    /// ManufacturerPartId - Link to Manufacturer part - used in forms
    /// </summary>
    public class JobPlanPart
    {
        public int Id { get; set; }
        public JobPlan JobPlan { get; set; }
        public int JobPlanId { get; set; }
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
    }
}

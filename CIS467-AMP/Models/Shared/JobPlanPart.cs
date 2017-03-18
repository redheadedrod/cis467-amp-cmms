namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Listing of parts for specific job plan
    /// 
    /// id - Record ID
    /// JobPlan - Link to Job plan
    /// JobPlanId - Link to Job plan - used in Forms
<<<<<<< HEAD
    /// ManufacturerVariant - Link to Manufacturer part
    /// ManufacturerVariantId - Link to Manufacturer part - used in forms
=======
    /// ManufacturerPart - Link to Manufacturer part
    /// ManufacturerPartId - Link to Manufacturer part - used in forms
>>>>>>> 4d04ce757e5de3c3f7ba312936954e2f28b6e28a
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

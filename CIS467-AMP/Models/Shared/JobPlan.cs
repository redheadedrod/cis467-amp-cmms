namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Job plan listings - Job plans are linked to Variants
    /// 
    /// Id - Record Id
    /// JobPlanName - Name of plan "example - Inbound Seal replacement"
    /// ManufacturerPart - Link to variant type this is related to
    /// ManufacturerPartId - Link to variant type this is related to - Used in Forms
    ///  </summary>
    public class JobPlan
    {
        public int Id { get; set; }
        public string JobPlanName { get; set; }
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
    }
}

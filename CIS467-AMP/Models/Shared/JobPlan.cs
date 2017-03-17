namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Job plan listings - Job plans are linked to Variants
    /// 
    /// Id - Record Id
    /// JobPlanName - Name of plan "example - Inbound Seal replacement"
    /// ManufacturerVariant - Link to variant type this is related to
    /// ManufacturerVariantId - Link to variant type this is related to - Used in Forms
    ///  </summary>
    public class JobPlan
    {
        public int Id { get; set; }
        public string JobPlanName { get; set; }
        public ManufacturerVariant ManufacturerVariant { get; set; }
        public int ManufacturerVariantId { get; set; }
    }
}

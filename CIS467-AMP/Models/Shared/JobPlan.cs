namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Job plan listings - Job plans are linked to Variants
    /// 
    /// Id - Record Id
    /// JobPlanName - Name of plan "example - Inbound Seal replacement"
<<<<<<< HEAD
    /// ManufacturerPart - Link to variant type this is related to
    /// ManufacturerPartId - Link to variant type this is related to - Used in Forms
=======
    /// ManufacturerVariant - Link to variant type this is related to
    /// ManufacturerVariantId - Link to variant type this is related to - Used in Forms
>>>>>>> 4d04ce757e5de3c3f7ba312936954e2f28b6e28a
    ///  </summary>
    public class JobPlan
    {
        public int Id { get; set; }
        public string JobPlanName { get; set; }
<<<<<<< HEAD
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
=======
        public ManufacturerVariant ManufacturerVariant { get; set; }
        public int ManufacturerVariantId { get; set; }
>>>>>>> 4d04ce757e5de3c3f7ba312936954e2f28b6e28a
    }
}

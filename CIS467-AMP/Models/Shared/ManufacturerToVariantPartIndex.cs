namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// This is a parts list that relates a specific part to 1 or more Variant
    /// 
    /// PartListID - Id for entry
    /// ManufacturerPart - Link to Manufacturer part 
    /// ManufacturerPartId - Link to Manufacturer part - used for forms
    /// ManufacturerVariant - Link to Variant
    /// ManufacturerVariant - Link to Variant - used for forms
    /// </summary>
    public class ManufacturerToVariantPartIndex
    {
        public int Id { get; set; }
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
        public ManufacturerVariant ManufacturerVariant { get; set; }
        public int ManufacturerVariantId { get; set; }
    }
}
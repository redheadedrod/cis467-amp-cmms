namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Variants of particular asset type - sort of a sub set of an asset type
    /// This should be the actual field that gets addressed for an asset type
    /// 
    /// VariantID - ID of this variant - must be unique 
    /// AssetTypeID - asset type this is related to
    /// Variant - short indicator of variant type. Can be a number or letters. 
    ///           example - could be model z of main type or 8 inch size etc
    /// VariantDescription - describe what this variant is "8 inch type T pump" etc
    /// </summary>
    public class Variant
    {
        public int Id { get; set; }
        public AssetType AssetTypeId { get; set; }
        public string VariantType { get; set; }
        public string VariantDescription { get; set; }
    }
}
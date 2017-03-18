namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Variants of particular asset type - sort of a sub set of an asset type
    /// This should be the actual field that gets addressed for an asset type
    /// 
    /// Id - Id of record
    /// AssetType - asset type this is related to
    /// AssetType - asset type this is related to - For forms
    /// Name - name of Variant type
    /// Description - Description of variant
    /// </summary>
    public class ManufacturerVariant
    {
        public int Id { get; set; }
        public AssetType AssetType { get; set; }
        public int AssetTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
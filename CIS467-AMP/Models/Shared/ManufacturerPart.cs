namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// Variants of particular asset type - sort of a sub set of an asset type
    /// This should be the actual field that gets addressed for an asset type
    /// 
    /// Id - Id of record
    /// AssetType - asset type this is related to
    /// AssetType - asset type this is related to - For forms
    /// Manufacturer - Manufacturer of part
    /// ManufacturerId - Manufacturer of part - for form
    /// Name - name of part
    /// Number - Manufacturer part number
    /// Description - Description of variant
    /// </summary>
    public class ManufacturerPart
    {
        public int Id { get; set; }
        public AssetType AssetType { get; set; }
        public int AssetTypeId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// List of currently installed assets
    /// 
    /// AssetInventoryID - id of particular entry
    /// AssetName - Name of specific asset
    /// VariantID - specific variant of asset type
    /// LocationID - id of specific location asset is related to or installed in
    /// Active - is asset currently active or has it been removed/replaced/ (Currently active = true)
    /// </summary>
    public class AssetInventory
    {
        public int Id { get; set; }
        public AssetType AssetType { get; set; }
        public Variant Variant { get; set; }
        public Map Map { get; set; }
        public bool Active { get; set; }
    }
}
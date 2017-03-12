namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// List of currently installed assets
    /// 
    /// Id - id of particular entry
    /// Name - Name of specific asset
    /// AssetType - bad field, needs to be removed
    /// VariantID - specific variant of asset type
    /// LocationID - id of specific location asset is related to or installed in
    /// Active - is asset currently active or has it been removed/replaced/ (Currently active = true)
    /// </summary>
    public class AssetInventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Variant Variant { get; set; }
        public int VariantId { get; set; }
        public Map Map { get; set; }
        public int MapId { get; set; }
        public bool Active { get; set; }
    }
}
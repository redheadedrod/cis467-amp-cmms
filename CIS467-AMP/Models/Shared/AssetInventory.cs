namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// List of currently installed assets
    /// 
    /// Id - id of particular entry
    /// Name - Name of specific asset
    /// ManufacturerPart - specific variant of asset type
    /// ManufacturerPartId - linked to above entry. Used when building forms
    /// Map - Location of Asset. 
    /// Active - is asset currently active or has it been removed/replaced/ (Currently active = true)
    /// </summary>
    public class AssetInventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
        public Map Map { get; set; }
        public int MapId { get; set; }
        public bool Active { get; set; }
    }
}

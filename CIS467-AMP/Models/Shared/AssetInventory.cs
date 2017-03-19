namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// List of currently installed assets
    /// 
    /// Id - id of particular entry
    /// Name - Name of specific asset
<<<<<<< HEAD
    /// ManufacturerPart - specific variant of asset type
    /// ManufacturerPartId - linked to above entry. Used when building forms
=======
    /// ManufacturerVariant - specific variant of asset type
    /// ManufacturerVariantId - linked to above entry. Used when building forms
>>>>>>> 4d04ce757e5de3c3f7ba312936954e2f28b6e28a
    /// Map - Location of Asset. 
    /// Active - is asset currently active or has it been removed/replaced/ (Currently active = true)
    /// </summary>
    public class AssetInventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
<<<<<<< HEAD
        public ManufacturerPart ManufacturerPart { get; set; }
        public int ManufacturerPartId { get; set; }
=======
        public ManufacturerVariant ManufacturerVariant { get; set; }
        public int ManufacturerVariantId { get; set; }
>>>>>>> 4d04ce757e5de3c3f7ba312936954e2f28b6e28a
        public Map Map { get; set; }
        public int MapId { get; set; }
        public bool Active { get; set; }
    }
}

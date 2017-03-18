namespace CIS467_AMP.Models.Shared
{
    /// <summary>
<<<<<<< HEAD
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
=======
    /// parts listing
    /// 
    /// Id - Record Id    
    /// Number - manufacturer parts number and can be alpha numeric
    /// Name - name of part
    /// Manufacturer - Link to Manufacturer
    /// ManufacturerId - Link to ManufacturerId - Used in forms
    /// ManufacturerPartType - type of part - allows for easy selection of parts for different variants - useful for setting up job plans mostly
    /// ManufacturerPartTypeId - type of part - used in forms
    ///  </summary>
    public class ManufacturerPart
    {
        public int Id { get; set; }
        public string Number { get; set;  } 
        public string Name { get; set; } 
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
        public ManufacturerPartType ManufacturerPartType { get; set; }
        public int ManufacturerPartTypeId { get; set; }
>>>>>>> 4d04ce757e5de3c3f7ba312936954e2f28b6e28a
    }
}
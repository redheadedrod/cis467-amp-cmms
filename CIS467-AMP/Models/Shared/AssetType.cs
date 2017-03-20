namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// This class will hold asset types
    /// Variants will branch off from this Model. This Model should not be used directly
    /// 
    /// Id - Record ID
    /// Name - Name of Asset Type 
    /// Manufacturer - Link to Manufacturer
    /// Manufacturer - Link to Manufacturer - used for forms
    /// </summary>
    public class AssetType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// This class will hold asset types
    /// 
    /// Additional classes that will link to this to define type totally include:
    /// variant - will be a list of variations (could be size, updates or special purpose items)
    /// jobplan - will list job plans if available
    /// partslist - will list parts lists for this type - parts lists will access the variants list and not this list directly
    /// </summary>
    public class AssetType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
    }
}
namespace CIS467_AMP.Models.Shared
{

    /// <summary>
    /// Class is used to create an index of contacts related to specific manufacturer. 
    /// This supports multiple contacts per manufacturer.
    /// 
    /// ID is the Id for each entry
    /// ManID is the Manufacturer ID
    /// ManContactID is the ID of a contact. 
    /// </summary>
    public class ManufacturerContactIndex
    {
        public int Id { get; set; }
        public Manufacturer ManId { get; set; } 
        public ManufacturerContact ManContactId { get; set; }
    }
}
namespace CIS467_AMP.Models.Shared
{
    /// <summary>
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
    }
}
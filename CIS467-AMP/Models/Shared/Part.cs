namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// parts listing
    /// 
    /// PartID - Id of entry    
    /// PartType - type of part - allows for easy selection of parts for different variants - useful for setting up job plans mostly
    /// Number - manufacturer parts number and can be alpha numeric
    /// Name - name of part
    /// ManID - manufacturer ID
    /// </summary>
    public class Part
    {
        public int Id { get; set; }
        public string Number { get; set;  } 
        public string Name { get; set; } 
        public Manufacturer Manufacturer { get; set; }
        public PartType PartType { get; set; }
    }
}
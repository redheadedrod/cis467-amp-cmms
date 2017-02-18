namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// This class is simply a manufacturer listing 
    /// Contacts will be associated through the Manufacturer Contact Index 
    ///
    /// ManId - Id for this entry
    /// Name - Name of manufacturer
    /// Address - Address of home office
    /// City - city of home office
    /// Region - State or region of home office
    /// Country - Country of home office
    /// PostalCode - Postal code of home office
    /// </summary>
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}
namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// This class is simply a listing of contacts
    /// 
    /// Id - Record Id
    /// Manufacturer - Link to Manufacturer
    /// ManufacturerId - Link to Manufacturer - Used in forms
    /// Name - full name of contact
    /// PhoneNumber - Phone number of contact
    /// FaxNumber - fax number for contact
    /// EmailAddress - Email Address for contact
    /// </summary>
    public class ManufacturerContact
    {
        public int Id { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}

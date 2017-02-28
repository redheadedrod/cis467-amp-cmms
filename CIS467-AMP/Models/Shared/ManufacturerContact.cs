namespace CIS467_AMP.Models.Shared
{
    /// <summary>
    /// This class is simply a listing of contacts
    /// 
    /// Id - Id for entry
    /// ManufacturerId - Id of Manufacturer
    /// Name - full name of contact
    /// PhoneNumber - Phone number of contact
    /// FaxNumber - fax number for contact
    /// EmailAddress - Email Address for contact
    /// </summary>
    public class ManufacturerContact
    {
        public int Id { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
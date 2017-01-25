using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Areas.Shared.Model
{
    /// <summary>
    /// This class is simply a listing of contacts
    /// 
    /// ManContactID - Id for entry
    /// Name - full name of contact
    /// PhoneNumber - Phone number of contact
    /// FaxNumber - fax number for contact
    /// EmailAddress - Email Address for contact
    /// </summary>
    public class ManufacturerContact
    {
        public int ManContactID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
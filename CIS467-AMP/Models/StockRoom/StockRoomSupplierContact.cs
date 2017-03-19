using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS467_AMP.Models.StockRoom
{
    /// <summary>
    /// This class is simply a listing of contacts
    /// 
    /// Id - Id for entry
    /// SupplierId - Id of Supplier
    /// Name - full name of contact
    /// PhoneNumber - Phone number of contact
    /// FaxNumber - fax number for contact
    /// EmailAddress - Email Address for contact
    /// </summary>
    public class StockRoomSupplierContact
    {
        public int Id { get; set; }
        public StockRoomSupplier StockRoomSupplier { get; set; }
        public int StockRoomSupplierId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Warehouse.Domain.Core.Models;

namespace Warehouse.Domain.Models
{
    public class Vendor : Entity<int>
    {
        #region Contructor
        public Vendor(int id,string vendorName, string vendorContact,
                    string vendorPhone, string direction,string company,
                    string userName)
        {
            Id = id;
            VendorName = vendorName;
            VendorContact = vendorContact;
            VendorPhone = vendorPhone;
            Direction = direction;
            Company = company;
            UserName = userName;
        }
        #endregion

        #region Properties
        public string VendorName { get; private set; }
        public string VendorContact { get; private set; }
        public string VendorPhone { get; private set; }
        public string Direction { get; private set; }
        public string Company { get; private set; }
        public string UserName { get; private set; }
        #endregion

        #region Asociation
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Reciving> Recivings { get; set; } 
        #endregion
    }
}

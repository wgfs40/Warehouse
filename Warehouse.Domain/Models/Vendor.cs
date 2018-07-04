using System;
using System.Collections.Generic;
using Warehouse.Domain.Core.Models;

namespace Warehouse.Domain.Models
{
    public class Vendor : Entity
    {
        #region Contructor
        public Vendor(Guid id,string vendorname,string vendorcontact,
                    string vendorphone, string direction,string company,
                    string username)
        {
            Id = id;
            VendorName = vendorname;
            VendorContact = vendorcontact;
            VendorPhone = vendorphone;
            Direction = direction;
            Company = company;
            UserName = username;
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

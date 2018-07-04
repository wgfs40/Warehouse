using System;
using System.Collections.Generic;
using Warehouse.Domain.Core.Models;

namespace Warehouse.Domain.Models
{
    public class Item : Entity<int>
    {
        #region Contructor
        public Item(int id, string itemNumber, string location, string description,
                    string partNumber, int vendorId, int categoryID, string uM,
                    int quantity, int max, int min,DateTime dateCreated, DateTime? dateModified,
                    string username,string company)
        {
            Id = id;
            ItemNumber = itemNumber;
            Location = location;
            Description = description;
            PartNumber = partNumber;
            VendorId = vendorId;
            CategoryID = categoryID;
            UM = uM;
            Quantity = quantity;
            Max = max;
            Min = min;
            DateCreated = dateCreated;
            DateModified = dateModified;
            Username = username;
            Company = company;

        }
        #endregion

        #region Properties
        public string ItemNumber { get; private set; }
        public string Location { get; private set; }
        public string Description { get; private set; }
        public string PartNumber { get; private set; }
        public int VendorId { get; private set; }
        public int CategoryID { get; private set; }
        public string UM { get; private set; }
        public int Quantity { get; private set; }
        public int Max { get; private set; }
        public int Min { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime? DateModified { get; private  set; }
        public string Username { get; private set; }
        //public StockStatus Status { get; set; }
        public string Company { get; private set; }
        #endregion

        #region Asociation
        public virtual ICollection<Despatch> Despatches { get; set; }
        public virtual ICollection<Reciving> Recivings { get; set; }
        public virtual Vendor Vendores { get; set; }
        public virtual Category Categories { get; set; } 
        #endregion
    }
}

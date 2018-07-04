using System;
using System.Collections.Generic;
using Warehouse.Domain.Core.Models;

namespace Warehouse.Domain.Models
{
    public class Item : Entity
    {
        #region Contructor
        public Item(Guid id, string itemnumber,string location, string description,
                    string partnumber,int idvendor,int categoryid,string um,
                    int qty, int max, int min,DateTime datecreated,DateTime? datemodified,
                    string username,string company)
        {
            Id = id;
            ItemNumber = itemnumber;
            Location = location;
            Description = description;
            PartNumber = partnumber;
            IDVendor = idvendor;
            CategoryID = categoryid;
            UM = um;
            Quantity = qty;
            Max = max;
            Min = min;
            DateCreated = datecreated;
            DateModified = datemodified;
            Username = username;
            Company = company;

        }
        #endregion

        #region Properties
        public string ItemNumber { get; private set; }
        public string Location { get; private set; }
        public string Description { get; private set; }
        public string PartNumber { get; private set; }
        public int IDVendor { get; private set; }
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

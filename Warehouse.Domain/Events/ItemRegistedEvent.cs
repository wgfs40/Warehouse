
using System;
using Warehouse.Domain.Core.Events;

namespace Warehouse.Domain.Events
{
    public class ItemRegistedEvent : Event
    {
        public ItemRegistedEvent(Guid id, string itemNumber, string location, string description,
                    string partNumber, int vendorId, int categoryID, string uM,
                    int quantity, int max, int min, DateTime dateCreated, DateTime? dateModified,
                    string username, string company)
        {
            AggregateId = id;
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

        #region Properties
        public string ItemNumber { get;}
        public string Location { get;}
        public string Description { get;}
        public string PartNumber { get;}
        public int VendorId { get;}
        public int CategoryID { get;}
        public string UM { get; }
        public int Quantity { get;}
        public int Max { get;}
        public int Min { get;}
        public DateTime DateCreated { get;}
        public DateTime? DateModified { get;}
        public string Username { get;}
        //public StockStatus Status { get; set; }
        public string Company { get;}
        #endregion
    }
}

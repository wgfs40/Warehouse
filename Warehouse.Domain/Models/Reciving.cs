using System;
using Warehouse.Domain.Core.Models;

namespace Warehouse.Domain.Models
{
    public class Reciving : Entity<int>
    {
        #region Contructor
        public Reciving(int id, string itemNumber, int quantity, decimal price,
                        string orderNumber, int? vendorId, DateTime date,
                        DateTime? dateModified, string username,string company)
        {
            Id = id;
            ItemNumber = itemNumber;
            Quantity = quantity;
            Price = price;
            OrderNumber = orderNumber;
            VendorId = vendorId;
            Date = date;
            DateModified = dateModified;
            Username = username;
            Company = company;
        }
        #endregion


        #region Properties
        public string ItemNumber { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public string OrderNumber { get; private set; }
        public int? VendorId { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime? DateModified { get; private set; }
        public string Username { get; private set; }
        public string Company { get; private set; }
        #endregion

        #region Asociation
        public virtual Item Items { get; set; }
        public virtual Vendor vendores { get; set; } 
        #endregion
    }
}

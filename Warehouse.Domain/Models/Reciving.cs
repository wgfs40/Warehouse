using System;
using Warehouse.Domain.Core.Models;

namespace Warehouse.Domain.Models
{
    public class Reciving : Entity
    {
        #region Contructor
        public Reciving(Guid id, string itemnumber,int qty,decimal price,
                        string ordernumber,int? vendorid,DateTime date,
                        DateTime? datemodified,string username,string company)
        {
            Id = id;
            ItemNumber = itemnumber;
            Quantity = qty;
            Price = price;
            OrderNumber = ordernumber;
            VendorId = vendorid;
            Date = date;
            DateModified = datemodified;
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

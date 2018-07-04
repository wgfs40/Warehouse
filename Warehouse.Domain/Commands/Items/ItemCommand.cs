using System;
using Warehouse.Domain.Core.Commands;

namespace Warehouse.Domain.Commands
{
    public abstract class ItemCommand : Command
    {
        public string ItemNumber { get; protected set; }
        public string Location { get; protected set; }
        public string Description { get; protected set; }
        public string PartNumber { get; protected set; }
        public int VendorId { get; protected set; }
        public int CategoryID { get; protected set; }
        public string UM { get; protected set; }
        public int Quantity { get; protected set; }
        public int Max { get; protected set; }
        public int Min { get; protected set; }
        public DateTime DateCreated { get; protected set; }
        public DateTime? DateModified { get; protected set; }
        public string Username { get; protected set; }
        //public StockStatus Status { get; set; }
        public string Company { get; protected set; }

        public override bool IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}

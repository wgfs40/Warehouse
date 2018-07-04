using System;
using Warehouse.Domain.Core.Models;

namespace Warehouse.Domain.Models
{
    public class Despatch : Entity<int>
    {
        #region Contructor
        public Despatch(int id,string itemNumber, int quantity,DateTime date,DateTime? dateModified,
                        string tagMachine, string username,string company)
        {
            Id = id;
            ItemNumber = itemNumber;
            Quantity = quantity;
            Date = date;
            DateModified = dateModified;
            TagMachine = tagMachine;
            Username = username;
            Company = company;

        }
        #endregion

        #region Properties
        public string ItemNumber { get; private set; }
        public int Quantity { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime? DateModified { get; private set; }
        public string TagMachine { get; private set; }
        public string Username { get; private set; }
        public string Company { get; private set; }
        #endregion

        #region Asociation
        public virtual Item Items { get; set; } 
        #endregion
    }
}

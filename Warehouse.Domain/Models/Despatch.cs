using System;
using Warehouse.Domain.Core.Models;

namespace Warehouse.Domain.Models
{
    public class Despatch : Entity
    {
        #region Contructor
        public Despatch(Guid id,string itemnumber,int qty,DateTime date,DateTime? datemodified,
                        string tagmachine,string username,string company)
        {
            Id = id;
            ItemNumber = itemnumber;
            Quantity = qty;
            Date = date;
            DateModified = datemodified;
            TagMachine = tagmachine;
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

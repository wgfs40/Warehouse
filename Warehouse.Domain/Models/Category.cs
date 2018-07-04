using System;
using System.Collections.Generic;
using Warehouse.Domain.Core.Models;

namespace Warehouse.Domain.Models
{
    public class Category : Entity<int>
    {
        #region Contructor
        public Category(int id,string description, string company)
        {
            Id = id;
            Description = description;
            Company = company;
        }
        #endregion
        #region Properties
        public string Description { get; private set; }
        public string Company { get; private set; }
        #endregion

        #region Asociation
        public virtual ICollection<Item> Items { get; set; } 
        #endregion
    }
}

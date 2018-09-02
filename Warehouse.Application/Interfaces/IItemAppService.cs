using PagedList.Core;
using System;
using System.Collections.Generic;
using Warehouse.Application.ViewModels;

namespace Warehouse.Application.Interfaces
{
    public interface IItemAppService : IDisposable
    {
        void Register(ItemViewModel itemViewModel);
        IEnumerable<ItemViewModel> GetAll();
        IPagedList<ItemViewModel> GetAllPaged(int index,int count);
        ItemViewModel GetById(Guid id);
        void Update(ItemViewModel itemViewModel);
        void Remove(Guid id);
        //IList<CustomerHistoryData> GetAllHistory(Guid id);
    }
}

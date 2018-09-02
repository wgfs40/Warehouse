using System.Collections.Generic;
using Warehouse.Domain.Models;

namespace Warehouse.Domain.Interfaces
{
    public interface IItemRepository : IRepository<Item>
    {
        List<Item> GetItemPaged(int page, int pagedCount,out int totalCount);
    }
}

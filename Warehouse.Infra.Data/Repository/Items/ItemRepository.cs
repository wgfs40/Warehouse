using System.Collections.Generic;
using System.Linq;
using Warehouse.Domain.Interfaces;
using Warehouse.Domain.Models;
using Warehouse.Infra.Data.Context;

namespace Warehouse.Infra.Data.Repository.Items
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(WirehouseContext context):base(context)
        {

        }

        List<Item> IItemRepository.GetItemPaged(int page, int pagedCount, out int totalCount)
        {
            List<Item> listitem = new List<Item>();
            var listitemall = GetAll().OrderBy(i => i.Id)
                .Skip(pagedCount * page)
                .Take(pagedCount).ToList();

            totalCount = GetAll().Count();

            return listitemall;
        }
    }
}

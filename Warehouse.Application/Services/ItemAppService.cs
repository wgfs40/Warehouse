using AutoMapper;
using AutoMapper.QueryableExtensions;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using Warehouse.Application.Interfaces;
using Warehouse.Application.ViewModels;
using Warehouse.Domain.Commands.Items;
using Warehouse.Domain.Core.Bus;
using Warehouse.Domain.Interfaces;
using Warehouse.Domain.Models;
using Warehouse.Infra.Data.Repository.EventSourcing;

namespace Warehouse.Application.Services
{
    public class ItemAppService : IItemAppService
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IMediatorHandler Bus;

        public ItemAppService(IMapper mapper, IItemRepository itemRepository, IEventStoreRepository eventStoreRepository, IMediatorHandler bus)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
            _eventStoreRepository = eventStoreRepository;
            Bus = bus;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<ItemViewModel> GetAll()
        {
            return _itemRepository.GetAll().ProjectTo<ItemViewModel>();
        }

        public IPagedList<ItemViewModel> GetAllPaged(int index, int count)
        {
            var totalpaged = 0;
            var itemlistpaged = _itemRepository.GetItemPaged(index, count, out totalpaged);

            
            var automapperitem = _mapper.Map<List<ItemViewModel>>(itemlistpaged);
            //List<ItemViewModel> itemlistViewModel = new List<ItemViewModel>();
            //foreach (var item in itemlistpaged)
            //{
            //    itemlistViewModel.Add(new ItemViewModel {
            //         Id = item.Id,
            //         Description = item.Description,
            //         ItemNumber = item.ItemNumber,
            //         PartNumber = item.PartNumber,
            //         Quantity = item.Quantity,
            //         UM = item.UM,
            //         Location = item.Location,
            //         Min = item.Min,
            //         Max = item.Max
            //    });
            //}

            IPagedList<ItemViewModel> BuilderItemPaged = new StaticPagedList<ItemViewModel>(automapperitem, index + 1,count,totalpaged);
            
            
            return BuilderItemPaged;
        }

        public ItemViewModel GetById(Guid id)
        {
            return _mapper.Map<ItemViewModel>(_itemRepository.GetById(id));
        }

        public void Register(ItemViewModel itemViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewItemCommand>(itemViewModel);
            Bus.SendCommand(registerCommand);
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(ItemViewModel itemViewModel)
        {
            throw new NotImplementedException();
        }
    }
}

using AutoMapper;
using System.Collections.Generic;
using Warehouse.Application.ViewModels;
using Warehouse.Domain.Models;

namespace Warehouse.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<List<Item>, List<ItemViewModel>>();
        }
    }
}

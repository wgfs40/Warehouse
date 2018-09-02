using AutoMapper;
using Warehouse.Application.ViewModels;
using Warehouse.Domain.Commands.Items;

namespace Warehouse.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ItemViewModel, RegisterNewItemCommand>()
                .ConstructUsing(i => new RegisterNewItemCommand(i.ItemNumber,i.Location, i.Description,i.PartNumber,
                i.VendorId,i.CategoryID,i.UM,i.Quantity,i.Max,i.Min,i.DateCreated,i.DateModified,i.Username,i.Company));

            //CreateMap<CustomerViewModel, UpdateCustomerCommand>()
            //    .ConstructUsing(c => new UpdateCustomerCommand(c.Id, c.Name, c.Email, c.BirthDate));
        }
    }
}

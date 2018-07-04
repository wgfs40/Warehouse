using FluentValidation;
using Warehouse.Domain.Commands;

namespace Warehouse.Domain.Validations.Item
{
    public class ItemValidation<T> : AbstractValidator<T> where T : ItemCommand
    {
        protected void ValidateItemNumber()
        {
            RuleFor(i => i.ItemNumber).NotEmpty().WithMessage("El item number no puede estar vacio.");            
        }

        protected void ValidateLocation()
        {
            RuleFor(i => i.Location).NotEmpty().WithMessage("La Localidad no puede estar vacia.");
        }
    }
}

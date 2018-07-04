using Warehouse.Domain.Commands.Items;

namespace Warehouse.Domain.Validations.Item
{
    public class RegisterNewItemCommandValidation : ItemValidation<RegisterNewItemCommand>
    {
        public RegisterNewItemCommandValidation()
        {
            ValidateItemNumber();
            ValidateLocation();
        }
    }
}

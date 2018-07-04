using MediatR;
using System;
using Warehouse.Domain.Core.Commands;
using Warehouse.Domain.Validations.Item;

namespace Warehouse.Domain.Commands.Items
{
    public class RegisterNewItemCommand : ItemCommand, IRequest
    {
        #region Contructor
        public RegisterNewItemCommand(string itemNumber, string location, string description,
                    string partNumber, int vendorId, int categoryID, string uM,
                    int quantity, int max, int min, DateTime dateCreated, DateTime? dateModified,
                    string username, string company)
        {
            ItemNumber = itemNumber;
            Location = location;
            Description = description;
            PartNumber = partNumber;
            VendorId = vendorId;
            CategoryID = categoryID;
            UM = uM;
            Quantity = quantity;
            Max = max;
            Min = min;
            DateCreated = dateCreated;
            DateModified = dateModified;
            Username = username;
            Company = company;

        }
        #endregion

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewItemCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}

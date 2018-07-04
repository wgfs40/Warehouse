using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Warehouse.Domain.Commands.Items;

namespace Warehouse.Domain.CommandHandlers.Items
{
    public interface IItemCommandHandler
    {
        Task<Unit> Handle(RegisterNewItemCommand request, CancellationToken cancellationToken);
    }
}
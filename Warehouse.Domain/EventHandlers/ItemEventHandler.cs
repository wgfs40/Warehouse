using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Warehouse.Domain.Events;

namespace Warehouse.Domain.EventHandlers
{
    public class ItemEventHandler :
        INotificationHandler<ItemRegistedEvent>
    {
        public Task Handle(ItemRegistedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}

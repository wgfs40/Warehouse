using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Warehouse.Domain.Commands.Items;
using Warehouse.Domain.Core.Bus;
using Warehouse.Domain.Core.Notifications;
using Warehouse.Domain.Interfaces;

namespace Warehouse.Domain.CommandHandlers.Items
{
    public class ItemCommandHandler : CommandHandler,
         INotificationHandler<RegisterNewItemCommand>
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMediatorHandler Bus;

        public ItemCommandHandler(IMediatorHandler bus, IUnitOfWork uow, INotificationHandler<DomainNotification> notifications, IItemRepository itemRepository) : base(uow, bus, notifications)
        {
            Bus = bus;
            _itemRepository = itemRepository;
        }

        

        Task INotificationHandler<RegisterNewItemCommand>.Handle(RegisterNewItemCommand notification, CancellationToken cancellationToken)
        {
            if (!notification.IsValid())
            {
                NotifyValidationErrors(notification);
                return Task.CompletedTask;
            }

            return Task.CompletedTask;
        }
    }
}

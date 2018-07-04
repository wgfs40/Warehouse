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
         IRequestHandler<RegisterNewItemCommand>
    {
        //private readonly ICustomerRepository _customerRepository;
        private readonly IMediatorHandler Bus;

        public ItemCommandHandler(IMediatorHandler bus, IUnitOfWork uow, INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            Bus = bus;
        }

        public  Task<Unit> Handle(RegisterNewItemCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Unit.Task;
            }

            return Unit.Task;
        }
    }
}

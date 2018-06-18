using System.Threading.Tasks;
using Warehouse.Domain.Core.Commands;
using Warehouse.Domain.Core.Events;

namespace Warehouse.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}

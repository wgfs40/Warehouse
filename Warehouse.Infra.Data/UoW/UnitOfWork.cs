using Warehouse.Domain.Interfaces;
using Warehouse.Infra.Data.Context;

namespace Warehouse.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WirehouseContext _context;

        public UnitOfWork(WirehouseContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

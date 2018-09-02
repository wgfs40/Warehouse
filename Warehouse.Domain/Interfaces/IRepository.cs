using System;
using System.Linq;
using PagedList.Core;

namespace Warehouse.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        IPagedList<TEntity> GetAllPaged(int index,int count);
        void Update(TEntity obj);
        void Remove(Guid id);
        int SaveChanges();
    }
}

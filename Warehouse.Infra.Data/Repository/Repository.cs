﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Warehouse.Domain.Interfaces;
using Warehouse.Infra.Data.Context;
using PagedList.Core;

namespace Warehouse.Infra.Data.Repository
{
    public  class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly WirehouseContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(WirehouseContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public IPagedList<TEntity> GetAllPaged(int index, int count)
        {
            return DbSet.ToPagedList(index, count);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Remove(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        
    }
}

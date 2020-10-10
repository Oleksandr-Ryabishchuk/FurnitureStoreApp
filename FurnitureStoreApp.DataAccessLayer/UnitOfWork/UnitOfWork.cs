using FurnitureStoreApp.DataAccessLayer.Data;
using FurnitureStoreApp.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStoreApp.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private bool disposed;
        private readonly DataContext dataContext;
        private Dictionary<Type, object> repositories;
        public UnitOfWork()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}

using FurnitureStoreApp.DataAccessLayer.Data;
using FurnitureStoreApp.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStoreApp.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        //private bool disposed;
        private readonly DataContext _dataContext;
        private readonly Dictionary<Type, object> repositories;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            repositories = new Dictionary<Type, object>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync()
        {
           await _dataContext.SaveChangesAsync();
        }
    }
}

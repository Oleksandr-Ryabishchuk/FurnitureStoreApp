using FurnitureStoreApp.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStoreApp.DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}

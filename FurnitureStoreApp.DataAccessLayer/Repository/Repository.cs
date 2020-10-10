using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace FurnitureStoreApp.DataAccessLayer.Repository
{
    public class Repository<T>: IRepository<T> where T : class
    {
        private DbSet<T> dbSet;

        public Repository(DbSet<T> db)
        {
            dbSet = db;
        }

        public Repository(DbContext dataContext)
        {
            dbSet = dataContext.Set<T>();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICollection<T> obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ICollection<T> obj)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}

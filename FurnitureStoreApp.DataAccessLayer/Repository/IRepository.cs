using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureStoreApp.DataAccessLayer.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Insert(ICollection<T> obj);

        void Insert(T obj);

        void Update(T obj);

        void Delete(int Id);

        void Delete(ICollection<T> obj);
    }
}

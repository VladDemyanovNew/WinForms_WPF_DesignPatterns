using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab10.Interfaces
{
    interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        void Add(T entity);

        void Update(T entity);

        void Remove(int id);
    }
}

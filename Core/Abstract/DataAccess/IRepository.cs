using Core.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Abstract.DataAccess
{
    public interface IRepository<T> where T : class, IEntity
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        T GetByDefault(Expression<Func<T, bool>> exp);
        List<T> GetAll(Expression<Func<T, bool>> exp = null);
        int Save();
    }
}

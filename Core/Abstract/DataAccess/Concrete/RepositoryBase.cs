using Core.Abstract.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.Abstract.DataAccess.Concrete
{
    public class RepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                Save();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> exp = null)
        {
            using (var context = new TContext())
            {
                return exp == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(exp).ToList();
            }
        }

        public TEntity GetByDefault(Expression<Func<TEntity, bool>> exp)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(exp);
            }
        }

        public void Remove(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                Save();
            }
        }

        public int Save()
        {
            using (var context = new TContext())
            {
                var result = context.SaveChanges();
                return result;
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Update(entity);
                Save();
            }
        }
    }
}

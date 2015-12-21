using ReportGen.Tools.DAL;
using ReportGen.Tools.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ReportGen.Tools.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {


        private DatabaseContext _ctx;

        public BaseRepository(DatabaseContext context)
        {
            this._ctx = context;
        }



        public virtual void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);
        }

        //public virtual async Task<IQueryable<T>> GetFilterInclude(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, string includeProperties, int size)
        public virtual List<T> GetAll()
        {
            return _ctx.Set<T>().ToList();
        }


        public virtual List<T> SearchBy(Expression<Func<T, bool>> searchBy, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, int size)
        {
            return _ctx.Set<T>().Where(searchBy).ToList();
        }

        public virtual List<T> SearchBy(Expression<Func<T, bool>> searchBy, string includeProperties)
        {

            IQueryable<T> result = _ctx.Set<T>().Where(searchBy);
            if (result.Any())
            {
                foreach (var property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    result = result.Include(property);
                }
            }
            return result.ToList();
        }

        public virtual T FindBy(Expression<Func<T, bool>> findBy, string includeProperties)
        {
            IQueryable<T> result = _ctx.Set<T>().Where(findBy);
            if (result.Any())
            {
                foreach (var property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    result = result.Include(property);
                }
            }
            return result.FirstOrDefault();
        }

        public virtual T FindBy(Expression<Func<T, bool>> findBy)
        {
            T result = _ctx.Set<T>().Where(findBy).SingleOrDefault();
            return result;
        }

        public virtual void Update(T entity)
        {
            _ctx.Set<T>().Attach(entity);
            _ctx.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _ctx.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
        }

    }
    
}

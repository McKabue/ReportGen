using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ReportGen.Tools.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        T FindBy(Expression<Func<T, bool>> findBy);
        List<T> GetAll();
        List<T> SearchBy(Expression<Func<T, bool>> searchBy, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy, int size);
        void Update(T entity);
    }
}
using Bilge_College.Models.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Bilge_College.Infrastructure.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<List<T>> GetByDefaults(Expression<Func<T, bool>> expression);
        Task<T> GetByDefault(Expression<Func<T, bool>> expression); 
        Task<T> GetById(int id);
        Task<List<TResult>> GetFiltered<TResult>(Expression<Func<T, TResult>> select, 
                                                 Expression<Func<T, bool>> where = null,
                                                 Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,
                                                 Func<IQueryable<T>, IIncludableQueryable<T,object>> join = null);
        Task<bool> Any(Expression<Func<T, bool>> expression);
        Task <List<T>> Where(Expression<Func<T, bool>> expression);
    }
}

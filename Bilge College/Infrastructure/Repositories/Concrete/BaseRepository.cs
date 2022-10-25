using Bilge_College.Infrastructure.Context;
using Bilge_College.Infrastructure.Repositories.Interfaces;
using Bilge_College.Models.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Bilge_College.Infrastructure.Repositories.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly BilgeDbContext _bilgeDbContext;
        protected readonly DbSet<T> _table;
        public BaseRepository(BilgeDbContext bilgeDbContext)
        {
            _bilgeDbContext = bilgeDbContext;
            _table =_bilgeDbContext.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _table.AddAsync(entity);
            await _bilgeDbContext.SaveChangesAsync();
        }

        public async Task<bool> Any(Expression<Func<T, bool>> expression) => await _table.AnyAsync(expression);

        public async Task Delete(T entity)
        {
            entity.Status = Status.Passive;
            entity.DeleteDate = DateTime.Now;
            await _bilgeDbContext.SaveChangesAsync();
        }

        public async Task<T> GetByDefault(Expression<Func<T, bool>> expression) => await _table.FirstOrDefaultAsync(expression);


        public async Task<List<T>> GetByDefaults(Expression<Func<T, bool>> expression) => await _table.Where(expression).ToListAsync();


        public async Task<T> GetById(int id) => await _table.FindAsync(id);

        public async Task Update(T entity)
        {
           _bilgeDbContext.Entry(entity).State = EntityState.Modified;
            await _bilgeDbContext.SaveChangesAsync();
        }

        public Task<List<T>> Where(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToListAsync();
        }
        public async Task<List<TResult>> GetFiltered<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
        {
            IQueryable<T> query = _table;
            if (join != null) query = join(query);
            if (where != null) query = query.Where(where);
            if (orderBy != null) return await orderBy(query).Select(select).ToListAsync();
            else return await query.Select(select).ToListAsync();
        }
    }
}

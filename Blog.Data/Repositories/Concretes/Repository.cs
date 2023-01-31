using Blog.Core.Enities;
using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext dbContext;
         
        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private  DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task  AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }
        public async Task<List<T>> GetAllAsync(Expression<Func<T,bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
             IQueryable<T> query = Table;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProperties.Any())
                foreach (var item in includeProperties)
                    query = query.Include(item);    
            return await query.ToListAsync();

        }

    }
}

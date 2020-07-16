using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TwoWaySynonymsApi.Common.Exceptions;
using TwoWaySynonymsApi.DataModel;
using TwoWaySynonymsApi.DataModel.Domain.Meta;
using TwoWaySynonymsApi.Repository.Meta;

namespace TwoWaySynonymsApi.Repository
{
    public abstract class BaseRepository<TKey, TModel> : IBaseRepository<TKey,TModel> 
        where TModel : BaseModel<TKey>
    {
        protected DbContext DbContext { get; }
        protected DbSet<TModel> DbSet { get; }

        protected BaseRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<TModel>();
        }

        public virtual async Task<ICollection<TModel>> GetAllAsync()
        {
            return await DbSet.Where(x => !x.Deleted).ToListAsync();
        }

        public virtual async Task<TModel> GetByIdAsync(TKey id)
        {
            return await  DbSet.FindAsync(id);
        }

        public virtual async Task<TModel> CreateAsync(TModel item)
        {
            DbSet.Add(item);
            await DbContext.SaveChangesAsync();
            return item;
        }

        public virtual async Task<TModel> UpdateAsync(TModel item)
        {
            var oldItem = await DbContext.Set<TModel>().FindAsync(item.Id);
            if (oldItem != null)
            {
                DbContext.Entry<TModel>(oldItem).CurrentValues.SetValues(item);
                await DbContext.SaveChangesAsync();
                return item;
            }
            throw new EntityNotExistException("BR001", $"Entity with id:{item.Id} not exists");
        }

        public virtual async Task DeleteAsync(TKey id)
        {
            var oldItem = await DbContext.Set<TModel>().FindAsync(id);
            if (oldItem != null)
            {
                oldItem.Deleted = true;
                await UpdateAsync(oldItem);
            }
        }
    }
}

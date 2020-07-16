using System.Threading.Tasks;
using TwoWaySynonymsApi.Common.Exceptions;
using TwoWaySynonymsApi.DataModel;
using TwoWaySynonymsApi.DataModel.Domain.Meta;
using TwoWaySynonymsApi.Repository.Meta;

namespace TwoWaySynonymsApi.Repository
{
    public abstract class BaseRepository<TKey, TModel> : BaseReadonlyRepository<TKey,TModel>, IBaseRepository<TKey,TModel> 
        where TModel : BaseModel<TKey>
    {
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

        protected BaseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

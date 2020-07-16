using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TwoWaySynonymsApi.DataModel;
using TwoWaySynonymsApi.DataModel.Domain.Meta;
using TwoWaySynonymsApi.Repository.Meta;

namespace TwoWaySynonymsApi.Repository
{
    public abstract class BaseReadonlyRepository<TKey, TModel> : IBaseReadonlyRepository<TKey, TModel>
        where TModel : BaseModel<TKey>
    {
        public virtual async Task<ICollection<TModel>> GetAllAsync()
        {
            return await DbSet.Where(x => !x.Deleted).ToListAsync();
        }

        public virtual async Task<TModel> GetByIdAsync(TKey id)
        {
            return await DbSet.FindAsync(id);
        }

        protected BaseReadonlyRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<TModel>();
        }
        protected DbContext DbContext { get; }
        protected DbSet<TModel> DbSet { get; }
    }
}

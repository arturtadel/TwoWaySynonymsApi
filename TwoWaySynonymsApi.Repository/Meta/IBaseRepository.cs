using System.Collections.Generic;
using System.Threading.Tasks;
using TwoWaySynonymsApi.DataModel.Domain.Meta;

namespace TwoWaySynonymsApi.Repository.Meta
{
    public interface IBaseRepository<TKey,TModel>
    where TModel : BaseModel<TKey>
    {
        Task<ICollection<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(TKey id);
        Task<TModel> CreateAsync(TModel item);
        Task<TModel> UpdateAsync(TModel item);
        Task DeleteAsync(TKey id);
    }
}

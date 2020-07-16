using System.Threading.Tasks;
using TwoWaySynonymsApi.DataModel.Domain.Meta;

namespace TwoWaySynonymsApi.Repository.Meta
{
    public interface IBaseRepository<TKey,TModel> : IBaseReadonlyRepository<TKey, TModel>
    where TModel : BaseModel<TKey>
    {
        Task<TModel> CreateAsync(TModel item);
        Task<TModel> UpdateAsync(TModel item);
        Task DeleteAsync(TKey id);
    }
}

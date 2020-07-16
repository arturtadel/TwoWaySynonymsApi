using System.Collections.Generic;
using System.Threading.Tasks;
using TwoWaySynonymsApi.DataModel.Domain.Meta;

namespace TwoWaySynonymsApi.Repository.Meta
{
    public interface IBaseReadonlyRepository<TKey, TModel>
        where TModel : BaseModel<TKey>
    {
        Task<ICollection<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(TKey id);
    }
}

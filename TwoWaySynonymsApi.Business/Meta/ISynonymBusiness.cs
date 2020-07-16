using System.Collections.Generic;
using System.Threading.Tasks;
using TwoWaySynonymsApi.Business.Dto;

namespace TwoWaySynonymsApi.Business.Meta
{
    public interface ISynonymBusiness
    {
        Task<IEnumerable<SynonymDto>> GetAllAsync();
        Task<SynonymDto> GetByIdAsync(int id);
        Task<SynonymDto> CreateAsync(SynonymDto synonym);
        Task<SynonymDto> UpdateAsync(int id, SynonymDto synonym);
        Task DeleteAsync(int id);
    }
}

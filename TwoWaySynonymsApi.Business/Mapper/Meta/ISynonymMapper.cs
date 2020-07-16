using TwoWaySynonymsApi.Business.Dto;
using TwoWaySynonymsApi.DataModel.Domain;

namespace TwoWaySynonymsApi.Business.Mapper.Meta
{
    public interface ISynonymMapper : ICustomMapper<Synonym, SynonymDto, int>
    {
    }
}

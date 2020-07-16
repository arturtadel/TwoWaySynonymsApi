using System.Collections.Generic;
using AutoMapper;
using TwoWaySynonymsApi.Business.Dto;
using TwoWaySynonymsApi.DataModel.Domain.Meta;

namespace TwoWaySynonymsApi.Business.Mapper.Meta
{
    public interface ICustomMapper<TModel, TDto, TKey> 
        where TModel : BaseModel<TKey>
        where TDto : BaseDto<TKey>
    {
        TDto ConvertToDto(TModel source);
        IEnumerable<TDto> ConvertToDtoCollection(IEnumerable<TModel> source);
        TModel ConvertToEntity(TDto source);
        IEnumerable<TModel> ConvertToEntityCollection(IEnumerable<TDto> source);
    }
}

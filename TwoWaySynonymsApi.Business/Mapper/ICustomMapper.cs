using System.Collections.Generic;
using AutoMapper;
using TwoWaySynonymsApi.Business.Dto;
using TwoWaySynonymsApi.Business.Mapper.Meta;
using TwoWaySynonymsApi.DataModel.Domain.Meta;

namespace TwoWaySynonymsApi.Business.Mapper
{
    public abstract class CustomMapper<TModel, TDto, TKey> : ICustomMapper<TModel, TDto, TKey> 
        where TModel : BaseModel<TKey> 
        where TDto : BaseDto<TKey>
    {
        protected IMapper Mapper { get; set; }

        protected CustomMapper()
        {
        }
        public TDto ConvertToDto(TModel source)
        {
            return Mapper.Map<TDto>(source);
        }

        public IEnumerable<TDto> ConvertToDtoCollection(IEnumerable<TModel> source)
        {
            return Mapper.Map<IEnumerable<TDto>>(source);
        }

        public TModel ConvertToEntity(TDto source)
        {
            return Mapper.Map<TModel>(source);
        }

        public IEnumerable<TModel> ConvertToEntityCollection(IEnumerable<TDto> source)
        {
            return Mapper.Map<IEnumerable<TModel>>(source);
        }
    }
}

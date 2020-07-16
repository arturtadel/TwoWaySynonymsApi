using AutoMapper;
using TwoWaySynonymsApi.Business.Dto;
using TwoWaySynonymsApi.Business.Mapper.Meta;
using TwoWaySynonymsApi.DataModel.Domain;

namespace TwoWaySynonymsApi.Business.Mapper
{
    public class SynonymViewMapper : CustomMapper<SynonymView, SynonymDto, int>, ISynonymViewMapper
    {
        public SynonymViewMapper()
        {
            Mapper = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<SynonymView, SynonymDto>();
                }
            ).CreateMapper();
        }
    }
}

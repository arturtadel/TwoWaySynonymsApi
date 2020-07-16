using AutoMapper;
using TwoWaySynonymsApi.Business.Dto;
using TwoWaySynonymsApi.Business.Mapper.Meta;
using TwoWaySynonymsApi.DataModel.Domain;

namespace TwoWaySynonymsApi.Business.Mapper
{
    public class SynonymMapper : CustomMapper<Synonym, SynonymDto, int>, ISynonymMapper
    {
        public SynonymMapper()
        {
            Mapper = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Synonym, SynonymDto>();
                    cfg.CreateMap<SynonymDto, Synonym>();
                }
            ).CreateMapper();
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using TwoWaySynonymsApi.Business.Dto;
using TwoWaySynonymsApi.Business.Mapper.Meta;
using TwoWaySynonymsApi.Business.Meta;
using TwoWaySynonymsApi.Repository.Meta;

namespace TwoWaySynonymsApi.Business
{
    public class SynonymBusiness : ISynonymBusiness
    {
        private readonly ISynonymRepository _synonymRepository;
        private readonly ISynonymMapper _synonymMapper;
        public SynonymBusiness(ISynonymRepository synonymRepository, ISynonymMapper synonymMapper)
        {
            _synonymRepository = synonymRepository;
            _synonymMapper = synonymMapper;
        }


        public async Task<IEnumerable<SynonymDto>> GetAllAsync()
        {
            return _synonymMapper.ConvertToDtoCollection(await _synonymRepository.GetAllAsync());
        }

        public async Task<SynonymDto> GetByIdAsync(int id)
        {
            return _synonymMapper.ConvertToDto(await _synonymRepository.GetByIdAsync(id));
        }

        public async Task<SynonymDto> CreateAsync(SynonymDto synonym)
        {
            return _synonymMapper.ConvertToDto(
                await _synonymRepository.CreateAsync(
                    _synonymMapper.ConvertToEntity(synonym)));
        }

        public async Task<SynonymDto> UpdateAsync(int id, SynonymDto synonym)
        {
            await DeleteAsync(id);
            return await CreateAsync(synonym);

        }

        public Task DeleteAsync(int id)
        {
            return _synonymRepository.DeleteAsync(id);
        }
    }
}

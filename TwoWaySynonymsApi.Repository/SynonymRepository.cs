using Microsoft.EntityFrameworkCore;
using TwoWaySynonymsApi.DataModel;
using TwoWaySynonymsApi.DataModel.Domain;
using TwoWaySynonymsApi.Repository.Meta;

namespace TwoWaySynonymsApi.Repository
{
    public class SynonymRepository : BaseRepository<int, Synonym>, ISynonymRepository
    {
        public SynonymRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

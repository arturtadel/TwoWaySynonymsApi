using TwoWaySynonymsApi.DataModel;
using TwoWaySynonymsApi.DataModel.Domain;

namespace TwoWaySynonymsApi.Repository.Meta
{
    public class SynonymViewRepository :BaseReadonlyRepository<int, SynonymView>, ISynonymViewRepository
    {
        public SynonymViewRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TwoWaySynonymsApi.DataModel.Domain;

namespace TwoWaySynonymsApi.DataModel
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //public DbSet<Synonym> Synonyms { get; set; }
    }
}

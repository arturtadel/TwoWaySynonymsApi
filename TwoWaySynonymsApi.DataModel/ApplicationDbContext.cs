using Microsoft.EntityFrameworkCore;
using TwoWaySynonymsApi.DataModel.Domain;

namespace TwoWaySynonymsApi.DataModel
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SynonymView>().ToView("SynonymsView");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Synonym> Synonyms { get; set; }

        public DbSet<SynonymView> SynonymsView { get; set; }
    }
}

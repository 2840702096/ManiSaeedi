using ManiSaeedi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Linq;
using System.Reflection;

namespace ManiSaeedi.Models.Context
{
    public class ManiContext : DbContext
    {
        public ManiContext(DbContextOptions<ManiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
        }

        #region Context

        public DbSet<AboutMe> AboutMe { get; set; }
        public DbSet<CommendationLetters> CommendationLetters { get; set; }
        public DbSet<ContactMe> ContactMe { get; set; }
        public DbSet<Degrees> Degrees { get; set; }
        public DbSet<Honors> Honors { get; set; }
        public DbSet<HonorVideos> HonorVideos { get; set; }
        public DbSet<MyBlogs> MyBlogs { get; set; }
        public DbSet<MyExperiences> MyExperiences { get; set; }
        public DbSet<MyServices> MyServices { get; set; }
        public DbSet<Speciality> Speciality { get; set; }

        #endregion

    }

    public class ToDoContextFactory : IDesignTimeDbContextFactory<ManiContext>
    {
        public ManiContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ManiContext>();
            builder.UseSqlServer("Data Source=.;Initial Catalog=ManiSaeedi;Integrated Security=True;MultipleActiveResultSets=true");
            return new ManiContext(builder.Options);
        }
    }
}

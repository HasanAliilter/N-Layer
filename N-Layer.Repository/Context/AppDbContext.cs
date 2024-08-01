using Microsoft.EntityFrameworkCore;
using N_Layer.Core.Models;
using System.Reflection;

namespace N_Layer.Repository.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public AppDbContext() { }

        public DbSet<Team> Teams {  get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //konfigürasyonlar için tekrar yazıp override yapıyoruz
        {
            //Kötü Kullanım
            /*modelBuilder.Entity<Team>().HasMany(t => t.Users).WithOne(t => t.Team).HasForeignKey(t => t.TeamId);*/
             
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //assembly üzerindeki tüm konfigürasyonları(IEntityTypeConfiguration) görür
        }
    }
}

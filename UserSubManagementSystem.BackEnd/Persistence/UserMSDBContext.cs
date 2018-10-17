using System.Data.Entity;
using UserSubManagementSystem.BackEnd.Core.Domain;
using UserSubManagementSystem.BackEnd.Persistence.EntityConfigurations;

namespace UserSubManagementSystem.BackEnd.Persistence
{
    public class UserMSDBContext : DbContext
    {
     public DbSet<User> Users { get; set; }

        public UserMSDBContext()
            :base("name=DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
using System.Data.Entity.ModelConfiguration;
using UserSubManagementSystem.BackEnd.Core.Domain;

namespace UserSubManagementSystem.BackEnd.Persistence.EntityConfigurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {

        public UserConfiguration() {

            ToTable("tbl_Users");
            HasKey(u => u.Id);

            Property(u => u.Name)
             .IsRequired()
             .HasMaxLength(300);


            Property(u => u.DateOfBirth)
                .IsOptional();

            Property(u => u.Mobile)
                .IsRequired()
                .HasMaxLength(300);

            Property(u => u.Email)
                  .IsRequired()
                  .HasMaxLength(300);
      
            Property(u => u.Country)
                .IsRequired()
                .HasMaxLength(300);

            Property(u => u.City)
                 .IsRequired()
                 .HasMaxLength(300);

            Property(u => u.Street)
                   .IsRequired()
                   .HasMaxLength(300);


        }

         

    }
}
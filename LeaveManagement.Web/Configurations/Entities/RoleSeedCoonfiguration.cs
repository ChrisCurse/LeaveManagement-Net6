using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedCoonfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            
            builder.HasData(
                new IdentityRole
                {
                    Id = "d1f1115c-d7cd-8e83-9501-20d5a516275b",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                 new IdentityRole
                 {
                     Id = "d1e2225c-d7bd-9e93-9601-60d5a816375b",
                     Name = Roles.User,
                     NormalizedName = Roles.User.ToUpper()
                 }


                );
        }
    }
}
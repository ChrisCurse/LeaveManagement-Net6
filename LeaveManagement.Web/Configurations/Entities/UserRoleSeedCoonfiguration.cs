using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedCoonfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "d1f1115c-d7cd-8e83-9501-20d5a516275b",
                    UserId = "dfba3c53-b419-4120-86cc-8d7d44e22fbd"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "d1e2225c-d7bd-9e93-9601-60d5a816375b",
                    UserId = "b1c1115c-d7cb-4e43-9501-19d5a312215d"
                }
                
                );
        }
    }
}
using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserSeedCoonfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                 new Employee
                 {
                     Id = "b1c1115c-d7cb-4e43-9501-19d5a312215d",
                     Email = "chris_curse@outlook.com",
                     UserName = "chris_curse@outlook.com",
                     NormalizedEmail = "CHRIS_CURSE@OUTLOOK.COM",
                     NormalizedUserName = "CHRIS_CURSE@OUTLOOK.COM",
                     Firstname = "Chris",
                     Lastname = "Curse",
                     PasswordHash = hasher.HashPassword(null, "Spiderman23!"),
                     EmailConfirmed = true,
                 },
                new Employee
                {
                    Id = "dfba3c53-b419-4120-86cc-8d7d44e22fbd",
                    Email = "admin@localhost.com",
                    UserName = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    Firstname = "admin",
                    Lastname = "admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd!"),
                    EmailConfirmed = true,
                }





                 );
        }
    }
}
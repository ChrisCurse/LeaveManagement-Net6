﻿using LeaveManagement.Web.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedCoonfiguration());
            builder.ApplyConfiguration(new UserSeedCoonfiguration());
            builder.ApplyConfiguration(new UserRoleSeedCoonfiguration());
        }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocation { get; set; }
        
       public DbSet<LeaveRequest> LeaveRequests { get; set; }
    }
}
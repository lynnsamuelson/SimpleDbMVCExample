using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleDbMVCExample.Models
{
    public class DepartmentContext : DbContext
    {
        public DbSet<Department> Department { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .ToTable("Department")
                .HasKey(c => c.DepartmentId);
        }
    }
}
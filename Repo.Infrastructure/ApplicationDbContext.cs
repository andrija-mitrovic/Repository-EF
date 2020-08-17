using Microsoft.EntityFrameworkCore;
using Repo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.Infrastructure
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}

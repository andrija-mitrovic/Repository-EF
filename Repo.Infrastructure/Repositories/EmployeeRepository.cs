using Repo.Core.Entities;
using Repo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.Infrastructure.Repositories
{
    public class EmployeeRepository:GenericRepository<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context) { }
    }
}

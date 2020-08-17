using Repo.Core.Interfaces;
using Repo.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Infrastructure.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IEmployeeRepository _employees;
        private IProjectRepository _projects;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEmployeeRepository Employees
            => _employees = _employees ?? new EmployeeRepository(_context);

        public IProjectRepository Projects
            => _projects = _projects ?? new ProjectRepository(_context);

        public async Task<bool> SaveAsync()
            => await _context.SaveChangesAsync() > 0;

        public void Dispose()
            => _context.Dispose();
    }
}

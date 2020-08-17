using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }
        IProjectRepository Projects { get; }
        Task<bool> SaveAsync();
    }
}

using Repo.Core.Entities;
using Repo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.Infrastructure.Repositories
{
    public class ProjectRepository:GenericRepository<Project>,IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext context) : base(context) { }
    }
}

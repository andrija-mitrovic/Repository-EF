using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repo.Core.Entities;
using Repo.Core.Interfaces;

namespace Repo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployeeAndProject()
        {
            var employee = new Employee
            {
                FirstName = "Andrija",
                LastName = "Mitrovic",
                Gender = "Male"
            };

            var project = new Project
            {
                Name = "Implement Repository"
            };

            await _unitOfWork.Employees.AddAsync(employee);
            await _unitOfWork.Projects.AddAsync(project);

            if (await _unitOfWork.SaveAsync())
                return Ok();

            throw new Exception("Unable to insert data in database");
        }
    }
}

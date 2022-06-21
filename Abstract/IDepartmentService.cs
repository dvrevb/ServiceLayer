using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Core.Models;
using Urprog.Entities.Concrete;

namespace Urprog.Business.Abstract
{
    public interface IDepartmentService
    {
        GetManyResult<Department> GetAll();
        Task<GetManyResult<Department>> GetAllAsync();
        GetOneResult<Department> GetDepartment(string departmentId);
        Task<GetOneResult<Department>> GetDepartmentAsync(string departmentId);
        Task<GetOneResult<Department>> CreateOneAsync(Department department);

    }
}

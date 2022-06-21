using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Business.Abstract;
using Urprog.Core.Models;
using Urprog.DataAccess.Abstract;
using Urprog.Entities.Concrete;

namespace Urprog.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDataAccess _departmentDataAccess;

        public DepartmentManager(IDepartmentDataAccess departmentDataAccess)
        {
            _departmentDataAccess = departmentDataAccess;
        }

        public async Task<GetOneResult<Department>> CreateOneAsync(Department department)
        {
            GetOneResult<Department> result = await _departmentDataAccess.InsertOneAsync(department);
            return result;
        }

        public GetManyResult<Department> GetAll()
        {
            var departmentList = _departmentDataAccess.GetAll();
            return departmentList;
        }

        public async Task<GetManyResult<Department>> GetAllAsync()
        {
            var departmentList = await _departmentDataAccess.GetAllAsync();
            return departmentList;
        }

        public GetOneResult<Department> GetDepartment(string departmentId)
        {
            var department = _departmentDataAccess.GetById(departmentId);
            return department;
        }

        public async Task<GetOneResult<Department>> GetDepartmentAsync(string departmentId)
        {
            var department = await _departmentDataAccess.GetByIdAsync(departmentId);
            return department;
        }
    }
}

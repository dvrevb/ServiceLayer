using AspNetCore.Identity.MongoDbCore.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Business.Abstract;
using Urprog.Core.Models;
using Urprog.DataAccess.Abstract;
using Urprog.Entities.Concrete;
using Urprog.Models.RequestModel.Admin;

namespace Urprog.Business.Concrete
{

    public class UserManager : IUserService
    {
        private readonly IUserDataAccess _userDataAccess;
        private readonly RoleManager<MongoIdentityRole> _roleManager;

        public UserManager(IUserDataAccess userDataAccess, RoleManager<MongoIdentityRole> roleManager)
        {
            _userDataAccess = userDataAccess;
            _roleManager = roleManager;
        }

        public GetManyResult<User> GetAll()
        {
            var userList = _userDataAccess.GetAll();
            return userList;
        }
        public async Task<GetManyResult<User>> GetAllAsync()
        {
            var userList = await _userDataAccess.GetAllAsync();
            return userList;
        }
        public GetOneResult<User> GetDepartment(string departmentId)
        {
            var department = _userDataAccess.GetById(departmentId);
            return department;
        }
        public IEnumerable<User> GetUsersWithUsername(string word)
        {
            var userList = GetAll().Result.Where(
                u => u.UserName.StartsWith(word));
            
            return userList;
        }

        public GetOneResult<User> UpdateOne(User user, string id)
        {
            GetOneResult<User> result = _userDataAccess.ReplaceOne(user, id,"guid");
            return result;
        }

       

        public async Task<GetOneResult<UserMainRole>> GetUserRoles(string id)
        {
            var result = new GetOneResult<UserMainRole>();
            try
            {

                var roles = _roleManager.Roles != null ? _roleManager.Roles.ToList() : null;

                var user = await _userDataAccess.GetByIdAsync(id, "guid");

                var userRoles = user != null && user.Entity != null
                    && user.Entity.Roles != null ?
                    user.Entity.Roles.Select(x => new UserRoles
                    {
                        Id = x.ToString(),
                        Name = roles.FirstOrDefault(y => y.Id == x).Name


                    }).ToList() : null;
                result.Entity = new UserMainRole
                {
                    Roles = roles,
                    UserRoleList = userRoles
                };
                result.Success = true;


            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Entity = null;
                result.Success = false;
            }
            return result;
        }

        
    }
}
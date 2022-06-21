using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Core.Models;
using Urprog.Entities.Concrete;
using Urprog.Models.RequestModel.Admin;

namespace Urprog.Business.Abstract
{
    public interface IUserService
    {
        GetManyResult<User> GetAll();
        Task<GetManyResult<User>> GetAllAsync();
        GetOneResult<User> UpdateOne(User user,string id);
        IEnumerable<User> GetUsersWithUsername(string word);
        //List<User> GetUsersByAge();
        Task<GetOneResult<UserMainRole>> GetUserRoles(string id);
    }
}

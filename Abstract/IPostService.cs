using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Core.Models;
using Urprog.Entities.Concrete;

namespace Urprog.Business.Abstract
{
    public interface IPostService
    {
        Task<GetOneResult<Post>> CreateOneAsync(Post post);
        Task<GetOneResult<Post>> GetById(string id);
        Task<GetManyResult<Post>> GetPostsIn30DaysAsync();
        Task<GetManyResult<Post>> GetPostsIn30DaysAsync(string project_id);
        Task<GetManyResult<Post>> GetBySupportIdAsync(string support_id);
        Task<GetOneResult<Post>> DeleteOneAsync(string post_id);
    }
}

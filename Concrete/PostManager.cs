using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Business.Abstract;
using Urprog.Core.Models;
using Urprog.Entities.Concrete;
using Urprog.DataAccess.Abstract;
namespace Urprog.Business.Concrete
{
    public class PostManager : IPostService
    {
        private readonly IPostDataAccess _postDataAccess;

        public PostManager(IPostDataAccess postDataAccess)
        {
            _postDataAccess = postDataAccess;
        }

        public async Task<GetOneResult<Post>> CreateOneAsync(Post post)
        {
            GetOneResult<Post> result = await _postDataAccess.InsertOneAsync(post);
            return result;
        }

        public async Task<GetOneResult<Post>> DeleteOneAsync(string post_id)
        {
            var result = await _postDataAccess.DeleteByIdAsync(post_id);
            return result;
        }

        public async Task<GetOneResult<Post>> GetById(string id)
        {
            var result = await _postDataAccess.GetByIdAsync(id);
            return result;
        }

        public async Task<GetManyResult<Post>> GetBySupportIdAsync(string support_id)
        {
            var result = await _postDataAccess.FilterByAsync(x => x.SupportId == support_id);
            return result;
        }
       

        public async Task<GetManyResult<Post>> GetPostsIn30DaysAsync()
        {
            DateTime currentDay = DateTime.Now;
            DateTime thirtyDaysAgo = currentDay.AddDays(-30);
            var postList = await _postDataAccess.FilterByAsync(p => p.CreatedDate<=currentDay && p.CreatedDate>thirtyDaysAgo);

            return postList;
        }

        public async Task<GetManyResult<Post>> GetPostsIn30DaysAsync(string project_id)
        {
            var result = await _postDataAccess.FilterByAsync(x => x.ProgId == project_id);
            return result;
        }
    }
}

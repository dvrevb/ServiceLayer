using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Core.Models;
using Urprog.Entities.Concrete;

namespace Urprog.Business.Abstract
{
    public interface ILikeService
    {
        Task<GetOneResult<Like>> CreateOneAsync(Like like);
        Task<GetManyResult<Like>> GetPostLikesAsync(string post_id);
        Task<GetOneResult<Like>> GetLikeAsync(string like_id);
        Task<GetOneResult<Like>> DeleteByPostAndUserId(string post_id, string user_id);
    }
}

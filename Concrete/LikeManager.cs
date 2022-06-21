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
    public class LikeManager : ILikeService
    {
        private readonly ILikeDataAccess _likeDataAccess;

        public LikeManager(ILikeDataAccess likeDataAccess)
        {
            _likeDataAccess = likeDataAccess;
        }
        public async Task<GetOneResult<Like>> CreateOneAsync(Like like)
        {
            GetOneResult<Like> result = await _likeDataAccess.InsertOneAsync(like);
            return result;
        }

        public async Task<GetOneResult<Like>> DeleteByPostAndUserId(string post_id, string user_id)
        {
            GetOneResult<Like> result = await _likeDataAccess.DeleteOneAsync(l => l.PostId == post_id && l.UserId == user_id);
            return result;
        }

        public async Task<GetOneResult<Like>> GetLikeAsync(string like_id)
        {
            var like = await _likeDataAccess.GetByIdAsync(like_id);
            return like;
        }

        public async Task<GetManyResult<Like>> GetPostLikesAsync(string post_id)
        {
            var commentList = await _likeDataAccess.FilterByAsync(l => l.PostId == post_id);
            return commentList;
        }
    }
}

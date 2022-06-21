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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDataAccess _commentDataAccess;

        public CommentManager(ICommentDataAccess commentDataAccess)
        {
            _commentDataAccess = commentDataAccess;
        }

        public async Task<GetOneResult<Comment>> CreateOneAsync(Comment comment)
        {
            GetOneResult<Comment> result = await _commentDataAccess.InsertOneAsync(comment);
            return result;
        }

        public async Task<GetOneResult<Comment>> GetCommentAsync(string comment_id)
        {
            var comment = await _commentDataAccess.GetByIdAsync(comment_id);
            return comment;
        }

        public async Task<GetManyResult<Comment>> GetCommentsAsync(string post_id)
        {
            var commentList =await _commentDataAccess.FilterByAsync(c => c.PostId == post_id);
            return commentList;
        }
    }
}

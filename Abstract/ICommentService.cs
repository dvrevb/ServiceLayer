using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Core.Models;
using Urprog.Entities.Concrete;

namespace Urprog.Business.Abstract
{
    public interface ICommentService
    {
        Task<GetOneResult<Comment>> CreateOneAsync(Comment comment);
        Task<GetManyResult<Comment>> GetCommentsAsync(string post_id);
        Task<GetOneResult<Comment>> GetCommentAsync(string comment_id);

    }
}

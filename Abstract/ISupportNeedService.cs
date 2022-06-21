using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Core.Models;
using Urprog.Entities.Concrete;

namespace Urprog.Business.Abstract
{
    public interface ISupportNeedService
    {
        GetOneResult<SupportNeed> CreateOne(SupportNeed supportNeed);
        Task<GetOneResult<SupportNeed>> CreateOneAsync(SupportNeed supportNeed);
        GetManyResult<SupportNeed> GetAll();
        Task<GetManyResult<SupportNeed>> GetAllAsync();
        Task<GetOneResult<SupportNeed>> GetSupportByIdAsync(string support_id);
        GetManyResult<SupportNeed> GetAllByProjectId(string id);
        Task<GetManyResult<SupportNeed>> GetAllByProjectIdAsync(string id);
        Task<GetOneResult<SupportNeed>> DeleteOneAsync(string id);
        Task<GetOneResult<SupportNeed>> UpdateOneAsync(SupportNeed supportNeed,string id);


    }
}

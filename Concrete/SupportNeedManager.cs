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
    public class SupportNeedManager : ISupportNeedService
    {

        private readonly ISupportNeedDataAccess _supportNeedDataAccess;

        public SupportNeedManager(ISupportNeedDataAccess supportNeedDataAccess)
        {
            _supportNeedDataAccess = supportNeedDataAccess;
        }

        public GetOneResult<SupportNeed> CreateOne(SupportNeed supportNeed)
        {
            GetOneResult<SupportNeed> result = _supportNeedDataAccess.InsertOne(supportNeed);
            return result;
        }

        public async Task<GetOneResult<SupportNeed>> CreateOneAsync(SupportNeed supportNeed)
        {
            GetOneResult<SupportNeed> result = await _supportNeedDataAccess.InsertOneAsync(supportNeed);
            return result;
        }
      
        public GetManyResult<SupportNeed> GetAll()
        {
            var result = _supportNeedDataAccess.GetAll();
            return result;
        }

        public async Task<GetManyResult<SupportNeed>> GetAllAsync()
        {
            var result = await  _supportNeedDataAccess.GetAllAsync();
            return result;
        }
        public async Task<GetOneResult<SupportNeed>> GetSupportByIdAsync(string support_id)
        {
            var result = await _supportNeedDataAccess.GetByIdAsync(support_id);
            return result;
        }
        public GetManyResult<SupportNeed> GetAllByProjectId(string id)
        {
            var result =  _supportNeedDataAccess.FilterBy(x => x.ProjectId == id);
            return result;
        }

        public async Task<GetManyResult<SupportNeed>> GetAllByProjectIdAsync(string id)
        {
            var result = await _supportNeedDataAccess.FilterByAsync(x => x.ProjectId == id);
            return result;
        }

        public Task<GetOneResult<SupportNeed>> DeleteOneAsync(string id)
        {
            var result = _supportNeedDataAccess.DeleteByIdAsync(id);
            return result;
        }

        public Task<GetOneResult<SupportNeed>> UpdateOneAsync(SupportNeed supportNeed,string id)
        {
            var result = _supportNeedDataAccess.ReplaceOneAsync(supportNeed,id);
            return result;
        }
    }
}

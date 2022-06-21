using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urprog.Core.Models;
using Urprog.Entities.Concrete;

namespace Urprog.Business.Abstract
{
    public interface IProjectService
    {
        public GetOneResult<Project> CreateOne(Project project);
        public Task<GetOneResult<Project>> CreateOneAsync(Project project);
        public GetOneResult<Project> GetProject(string project_id);
        public Task<GetOneResult<Project>> GetProjectAsync(string project_id);
        public GetOneResult<Project> UpdateOne(Project project, string id);
        public Task<GetOneResult<Project>> UpdateOnetAsync(Project project, string id);
        Task<GetManyResult<Project>> GetAllAsync();


    }
}

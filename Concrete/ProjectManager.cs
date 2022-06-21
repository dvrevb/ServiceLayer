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
    public class ProjectManager: IProjectService
    {

        private readonly IProjectDataAccess _projectDataAccess;

        public ProjectManager(IProjectDataAccess projectDataAccess)
        {
            _projectDataAccess = projectDataAccess;
        }

        public GetOneResult<Project> CreateOne(Project project)
        {
            GetOneResult<Project> result= _projectDataAccess.InsertOne(project);
            return result;
        }

        public async Task<GetOneResult<Project>> CreateOneAsync(Project project)
        {
            var result = await _projectDataAccess.InsertOneAsync(project);
            return result;
        }

        public async Task<GetManyResult<Project>> GetAllAsync()
        {
            var projectList =await  _projectDataAccess.GetAllAsync();
            return projectList;
        }

        public GetOneResult<Project> GetProject(string project_id)
        {
            GetOneResult<Project> result = _projectDataAccess.GetById(project_id);
            return result;
        }
        public async Task<GetOneResult<Project>> GetProjectAsync(string project_id)
        { 
            var project = await _projectDataAccess.GetByIdAsync(project_id);
            return project;
        }
        public GetOneResult<Project> UpdateOne(Project project, string id)
        {
            GetOneResult<Project> result = _projectDataAccess.ReplaceOne(project, id);
            return result;
        }

        public async Task<GetOneResult<Project>> UpdateOnetAsync(Project project, string id)
        {
            GetOneResult<Project> result = await _projectDataAccess.ReplaceOneAsync(project, id);
            return result;
        }
    }
}

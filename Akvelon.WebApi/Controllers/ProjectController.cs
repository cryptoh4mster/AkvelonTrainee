using Akvelon.Business.Interfaces;
using Akvelon.Business.Models;
using Akvelon.DTO.Models.Requests;
using Akvelon.DTO.Models.Responses;
using Akvelon.WebApi.Controllers.Base;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Akvelon.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : BaseController
    {
        private readonly IProjectService _projectService;
        public ProjectController(IMapper mapper, IProjectService projectService) : base(mapper)
        {
            _projectService = projectService;
        }
        
        /// <summary>
        /// Find project by id
        /// </summary>
        /// <param name="request">Project id in request</param>
        /// <returns>Project</returns>
        [HttpGet]
        [Route("project")]
        public async Task<IActionResult> GetProjectById([FromQuery] GetProjectByIdRequest request)
        {
            var result = await _projectService.GetProjectById(request.ProjectId);

            return Ok(_mapper.Map<ProjectResponse>(result));
        }

        /// <summary>
        /// Find all projects
        /// </summary>
        /// <returns>All projects</returns>
        [HttpGet]
        [Route("projects")]
        public async Task<IActionResult> GetAllProjects()
        {
            var result = await _projectService.GetAllProjects();

            return Ok(_mapper.Map<IEnumerable<ProjectResponse>>(result));
        }

        /// <summary>
        /// Add new project
        /// </summary>
        /// <param name="request">New project</param>
        /// <returns></returns>
        [HttpPost]
        [Route("project")]
        public async Task<IActionResult> AddNewProject(NewProjectRequest request)
        {
            var newProjectModel = _mapper.Map<ProjectModel>(request);

            await _projectService.AddNewProject(newProjectModel);

            return Ok("");
        }

        /// <summary>
        /// Update exist project
        /// </summary>
        /// <param name="request">Project with new values</param>
        /// <returns></returns>
        [HttpPut]
        [Route("project")]
        public async Task<IActionResult> UpdateProject(UpdateProjectRequest request)
        {
            var updateProjectModel = _mapper.Map<ProjectModel>(request);

            await _projectService.UpdateProject(updateProjectModel);

            return Ok("");
        }

        /// <summary>
        /// Delete exist project
        /// </summary>
        /// <param name="request">Project id in request</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("project")]
        public async Task<IActionResult> DeleteProject([FromQuery] GetProjectByIdRequest request)
        {
            await _projectService.DeleteProjectById(request.ProjectId);

            return Ok("");
        }

        /// <summary>
        /// Find project with tasks by id
        /// </summary>
        /// <param name="request">Project id in request</param>
        /// <returns></returns>
        [HttpGet]
        [Route("project-with-tasks")]
        public async Task<IActionResult> GetProjectWithTasksById([FromQuery] GetProjectByIdRequest request)
        {
            var result = await _projectService.GetProjectWithTasksById(request.ProjectId);

            return Ok(_mapper.Map<ProjectWithTasksResponse>(result));
        }

        /// <summary>
        /// Find projects by criteria
        /// </summary>
        /// <param name="request">Different criterias</param>
        /// <returns>Collection of projects by criterias</returns>
        [HttpPost]
        [Route("projects-by-criteria")]
        public async Task<IActionResult> GetProjectsByCriteria(ProjectCriteriaRequest request)
        {
            var projectCriteriaModel = _mapper.Map<ProjectCriteriaModel>(request);

            var result = await _projectService.GetProjectsByCriteria(projectCriteriaModel);

            return Ok(_mapper.Map<IEnumerable<ProjectResponse>>(result));
        }
    }
}

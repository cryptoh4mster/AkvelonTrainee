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

        [HttpGet]
        [Route("project")]
        public async Task<IActionResult> GetProjectById([FromQuery] GetProjectByIdRequest request)
        {
            var result = await _projectService.GetProjectById(request.ProjectId);

            return Ok(_mapper.Map<ProjectResponse>(result));
        }

        [HttpGet]
        [Route("projects")]
        public async Task<IActionResult> GetAllProjects()
        {
            var result = await _projectService.GetAllProjects();

            return Ok(_mapper.Map<IEnumerable<ProjectResponse>>(result));
        }

        [HttpPost]
        [Route("project")]
        public async Task<IActionResult> AddNewProject(NewProjectRequest request)
        {
            var newProjectModel = _mapper.Map<ProjectModel>(request);

            await _projectService.AddNewProject(newProjectModel);

            return Ok("");
        }

        [HttpPatch]
        [Route("project")]
        public async Task<IActionResult> UpdateProject(UpdateProjectRequest request)
        {
            var updateProjectModel = _mapper.Map<ProjectModel>(request);

            await _projectService.UpdateProject(updateProjectModel);

            return Ok("");
        }

        [HttpDelete]
        [Route("project")]
        public async Task<IActionResult> DeleteProject([FromQuery] GetProjectByIdRequest request)
        {
            await _projectService.DeleteProjectById(request.ProjectId);

            return Ok("");
        }

        [HttpGet]
        [Route("project-with-tasks")]
        public async Task<IActionResult> GetProjectWithTasksById([FromQuery] GetProjectByIdRequest request)
        {
            var result = await _projectService.GetProjectWithTasksById(request.ProjectId);

            return Ok(_mapper.Map<ProjectWithTasksResponse>(result));
        }

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

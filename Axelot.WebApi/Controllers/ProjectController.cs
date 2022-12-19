using AutoMapper;
using Axelot.Business.Interfaces;
using Axelot.Business.Models;
using Axelot.DTO.Models.Requests;
using Axelot.DTO.Models.Responses;
using Axelot.WebApi.Controllers.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Axelot.WebApi.Controllers
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
        public async Task<IActionResult> GetAllProject()
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
    }
}

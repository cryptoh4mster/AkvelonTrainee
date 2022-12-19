using AutoMapper;
using Axelot.Business.Interfaces;
using Axelot.Business.Models;
using Axelot.Core.Exceptions;
using Axelot.DAL.Entities;
using Axelot.DAL.Interfaces;
using Axelot.DAL.Interfaces.Repositories;

namespace Axelot.Business.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IMapper _mapper;
        private readonly IProjectRepository _projectRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProjectService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _projectRepository = _unitOfWork.ProjectRepository;
        }
        public async Task AddNewProject(ProjectModel projectModel)
        {
            var projectEntity = _mapper.Map<ProjectEntity>(projectModel);

            _projectRepository.Add(projectEntity);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProjectModel>> GetAllProjects()
        {
            var projectsEntities = await _projectRepository.GetAllAsync();

            if (!projectsEntities.Any())
                throw new EntityNotFoundException(nameof(projectsEntities));

            return _mapper.Map<IEnumerable<ProjectModel>>(projectsEntities);

        }

        public async Task<ProjectModel> GetProjectById(Guid projectId)
        {
            var projectEntity = await _projectRepository.FindSingleAsync(projectId);

            if (projectEntity is null)
                throw new EntityNotFoundException(nameof(projectEntity));

            return _mapper.Map<ProjectModel>(projectEntity);
        }

        public async Task DeleteProjectById(Guid projectId)
        {
            var projectEntity = await _projectRepository.FindSingleAsync(projectId);

            if (projectEntity is null)
                throw new EntityNotFoundException(nameof(projectEntity));

            _projectRepository.Delete(projectEntity);
        }

        public async Task UpdateProject(ProjectModel projectModel)
        {
            var projectEntity = _mapper.Map<ProjectEntity>(projectModel);

            _projectRepository.Update(projectEntity);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}

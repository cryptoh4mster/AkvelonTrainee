using Akvelon.Core.Enums;

namespace Akvelon.DAL.Entities
{
    public class ProjectEntity : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public ProjectsStatus Status { get; set; }
        public int Priority { get; set; }
        public ICollection<TaskEntity> Tasks { get; private set; } = new List<TaskEntity>();
    }
}

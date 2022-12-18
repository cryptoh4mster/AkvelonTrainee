using Axelot.Core.Enums;

namespace Axelot.DAL.Entities
{
    public class ProjectEntity : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public ProjectStatus Status { get; set; }
        public int Priority { get; set; }
        public ICollection<TaskEntity> Tasks { get; private set; } = new List<TaskEntity>();
    }
}

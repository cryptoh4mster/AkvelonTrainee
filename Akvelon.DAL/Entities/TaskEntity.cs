using Akvelon.Core.Enums;

namespace Akvelon.DAL.Entities
{
    /// <summary>
    /// Entity for task data in db
    /// </summary>
    public class TaskEntity : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TasksStatus Status { get; set; }
        public int Priority { get; set; }
        public Guid ProjectId { get; set; }
        public ProjectEntity Project { get; set; }
    }   
}

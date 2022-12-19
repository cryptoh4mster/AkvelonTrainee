using Akvelon.Core.Enums;

namespace Akvelon.Business.Models
{
    public class TaskModel
    {
        public Guid TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TasksStatus Status { get; set; }
        public int Priority { get; set; }
        public Guid ProjectId { get; set; }
        public ProjectModel Project { get; set; }
    }
}

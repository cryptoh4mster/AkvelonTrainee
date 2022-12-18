namespace Axelot.DAL.Entities
{
    public class TaskEntity : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public int Priority { get; set; }
        public Guid ProjectId { get; set; }
        public ProjectEntity Project { get; set; }
    }   
}

namespace Axelot.DTO.Models.Requests
{
    public class UpdateTaskRequest
    {
        public Guid TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
        public Guid ProjectId { get; set; }
    }
}

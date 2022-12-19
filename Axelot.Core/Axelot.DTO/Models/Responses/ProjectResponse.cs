namespace Axelot.DTO.Models.Responses
{
    public class ProjectResponse
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
        public IEnumerable<TaskResponse> Tasks { get; set; }
    }
}

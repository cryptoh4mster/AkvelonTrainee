namespace Akvelon.DTO.Models.Requests
{
    public class NewTaskRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
        public Guid ProjectId { get; set; }
    }
}

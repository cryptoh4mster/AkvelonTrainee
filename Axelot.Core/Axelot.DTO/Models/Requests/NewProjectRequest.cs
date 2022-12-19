namespace Axelot.DTO.Models.Requests
{
    public class NewProjectRequest
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
    }
}

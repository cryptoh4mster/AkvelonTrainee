namespace Akvelon.DTO.Models.Requests
{
    public class ProjectCriteriaRequest
    {
        public string SortByField { get; set; }
        public bool SortOrder { get; set; }  
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
    }
}

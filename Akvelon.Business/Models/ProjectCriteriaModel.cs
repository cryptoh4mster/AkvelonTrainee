using Akvelon.Core.Enums;
using System.Reflection;

namespace Akvelon.Business.Models
{
    /// <summary>
    /// BusinessModel with criterias for filtering and sorting result projects
    /// </summary>
    public class ProjectCriteriaModel
    {
        public PropertyInfo? SortByField { get; set; }
        public string SortOrder { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public ProjectsStatus Status { get; set; }
        public int Priority { get; set; }
    }
}

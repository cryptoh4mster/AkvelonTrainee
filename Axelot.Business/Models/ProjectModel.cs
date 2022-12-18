﻿using Axelot.Core.Enums;

namespace Axelot.Business.Models
{
    public class ProjectModel
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public ProjectStatus Status { get; set; }
        public int Priority { get; set; }
        public IEnumerable<TaskModel> Tasks { get; set; }
    }
}

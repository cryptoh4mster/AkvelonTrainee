using Akvelon.Core.Enums;
using Akvelon.DTO.Models.Requests;
using FluentValidation;

namespace Akvelon.DTO.Validation
{
    public class ProjectCriteriaValidator : AbstractValidator<ProjectCriteriaRequest>
    {
        public ProjectCriteriaValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().ProjectName();
            RuleFor(x => x.SortByField).NotEmpty().NotNull().Must(field => Char.IsUpper(field[0]));
            RuleFor(x => x.SortOrder).NotEmpty().NotNull();
            RuleFor(x => x.Status).NotEmpty().NotNull().Must(status => Enum.IsDefined(typeof(ProjectsStatus), status));
            RuleFor(x => x.Priority).NotEmpty().NotNull();
            RuleFor(x => x.StartDate).NotEmpty().NotNull();
            RuleFor(x => x.CompletionDate).NotEmpty().NotNull();
        }
    }
}

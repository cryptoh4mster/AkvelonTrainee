using Akvelon.Core.Enums;
using Akvelon.DTO.Models.Requests;
using FluentValidation;

namespace Akvelon.DTO.Validation
{
    public class UpdateProjectValidator : AbstractValidator<UpdateProjectRequest>
    {
        public UpdateProjectValidator() 
        {
            RuleFor(x => x.ProjectId).NotEmpty().NotNull();
            RuleFor(x => x.Name).NotEmpty().NotNull().ProjectName();
            RuleFor(x => x.Status).NotEmpty().NotNull().Must(status => Enum.IsDefined(typeof(ProjectsStatus), status));
            RuleFor(x => x.StartDate).NotEmpty().NotNull();
            RuleFor(x => x.CompletionDate).NotEmpty().NotNull();
            RuleFor(x => x.Priority).NotNull();
        }
    }
}

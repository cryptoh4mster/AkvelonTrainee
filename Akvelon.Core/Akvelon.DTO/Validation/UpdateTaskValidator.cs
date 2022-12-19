using Akvelon.Core.Enums;
using Akvelon.DTO.Models.Requests;
using FluentValidation;

namespace Akvelon.DTO.Validation
{
    public class UpdateTaskValidator : AbstractValidator<UpdateTaskRequest>
    {
        public UpdateTaskValidator() 
        {
            RuleFor(x => x.TaskId).NotEmpty().NotNull();
            RuleFor(x => x.Name).NotEmpty().NotNull().TaskName();
            RuleFor(x => x.Description).NotEmpty().NotNull().TaskDescription();
            RuleFor(x => x.Status).NotEmpty().NotNull().Must(status => Enum.IsDefined(typeof(TasksStatus), status));
            RuleFor(x => x.Priority).NotNull();
            RuleFor(x => x.ProjectId).NotEmpty().NotNull();
        }
    }
}

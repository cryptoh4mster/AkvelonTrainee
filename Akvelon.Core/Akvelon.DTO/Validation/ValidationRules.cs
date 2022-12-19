using FluentValidation;

namespace Akvelon.DTO.Validation
{
    public static class ValidationRules
    {
        public static IRuleBuilderOptions<T, string> ProjectName<T>(this IRuleBuilder<T, string> ruleBuilder) =>
            ruleBuilder
                .MinimumLength(5)
                .WithMessage("Project name must be no shorter than 5 characters..")
                .MaximumLength(50)
                .WithMessage("Project name must be no longer than 50 characters..");

        public static IRuleBuilderOptions<T, string> TaskName<T>(this IRuleBuilder<T, string> ruleBuilder) =>
            ruleBuilder
                .MinimumLength(5)
                .WithMessage("Project name must be no shorter than 5 characters..")
                .MaximumLength(50)
                .WithMessage("Project name must be no longer than 50 characters..");

        public static IRuleBuilderOptions<T, string> TaskDescription<T>(this IRuleBuilder<T, string> ruleBuilder) =>
            ruleBuilder
                .MinimumLength(10)
                .WithMessage("Project name must be no shorter than 10 characters..")
                .MaximumLength(100)
                .WithMessage("Project name must be no longer than 50 characters..");

        public static IRuleBuilderOptions<T, string> SortByField<T>(this IRuleBuilder<T, string> ruleBuilder) =>
            ruleBuilder
                .MinimumLength(1)
                .WithMessage("SortByField value must be match with property in code");

    }
}

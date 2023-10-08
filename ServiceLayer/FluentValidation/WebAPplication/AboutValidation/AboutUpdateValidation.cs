using EntityLayer.WebApplication.ViewModels.AboutVM;
using FluentValidation;
using ServiceLayer.Messages.WebApplication;

namespace ServiceLayer.FluentValidation.WebAPplication.AboutValidation
{
    public class AboutUpdateValidation : AbstractValidator<AboutUpdateVM>
    {
        public AboutUpdateValidation()
        {
            RuleFor(x => x.Header)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Header"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Header"))
                .MaximumLength(200).WithMessage(ValidationMessages.MaximumCharachterAllowence("Header", 200));
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Description"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Description"))
                .MaximumLength(5000).WithMessage(ValidationMessages.MaximumCharachterAllowence("Description", 5000));
            RuleFor(x => x.Clients)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Clients"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Clients"))
                .GreaterThan(0).WithMessage(ValidationMessages.GreaterThanMessage("Clients", 0))
                .LessThan(1000).WithMessage(ValidationMessages.LessThanMessage("Clients", 1000));
            RuleFor(x => x.Projects)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Projects"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Projects"))
                .GreaterThan(0).WithMessage(ValidationMessages.GreaterThanMessage("Projects", 0))
                .LessThan(10000).WithMessage(ValidationMessages.LessThanMessage("Projects", 10000));
            RuleFor(x => x.HoursOfSupport)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Hours Of Support"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Hours Of Support"))
                .GreaterThan(0).WithMessage(ValidationMessages.GreaterThanMessage("Hours Of Support", 0))
                .LessThan(100000).WithMessage(ValidationMessages.LessThanMessage("Hours Of Support", 100000));
            RuleFor(x => x.HardWorkers)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Hard Workers"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Hard Workers"))
                .GreaterThan(0).WithMessage(ValidationMessages.GreaterThanMessage("Hard Workers", 0))
                .LessThan(99).WithMessage(ValidationMessages.LessThanMessage("Hard Workers", 99));



        }
    }
}

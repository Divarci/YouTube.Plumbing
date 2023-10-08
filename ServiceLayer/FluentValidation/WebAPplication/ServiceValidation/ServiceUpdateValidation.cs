using EntityLayer.WebApplication.ViewModels.Service;
using FluentValidation;
using ServiceLayer.Messages.WebApplication;

namespace ServiceLayer.FluentValidation.WebAPplication.ServiceValidation
{
    public class ServiceUpdateValidation : AbstractValidator<ServiceUpdateVM>
    {
        public ServiceUpdateValidation()
        {
            RuleFor(x => x.Name)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Name"))
               .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Name"))
               .MaximumLength(200).WithMessage(ValidationMessages.MaximumCharachterAllowence("Name", 200));
            RuleFor(x => x.Description)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Description"))
               .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Description"))
               .MaximumLength(2000).WithMessage(ValidationMessages.MaximumCharachterAllowence("Description", 2000));
            RuleFor(x => x.Icon)
               .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Icon"))
               .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Icon"))
               .MaximumLength(100).WithMessage(ValidationMessages.MaximumCharachterAllowence("Icon", 100));
        }
    }
}

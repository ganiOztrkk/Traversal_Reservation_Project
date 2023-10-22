using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules;

public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTOs>
{
    public AnnouncementValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Please write a title.");
        RuleFor(x => x.Content).NotEmpty().WithMessage("Please write a content.");
        RuleFor(x => x.Title).MinimumLength(5).WithMessage("Minimum 5 characters");
        RuleFor(x => x.Content).MaximumLength(200).WithMessage("Maximum 200 characters");
    }
}
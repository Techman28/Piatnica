using FluentValidation;
using ITMCode.Piatnica.Api.DTOs;


namespace ITMCode.Piatnica.Api.Validators
{
    public class UpdateEventHistoryDtoValidator : AbstractValidator<UpdateEventHistoryDto>
    {
        UpdateEventHistoryDtoValidator()
        {
            RuleFor(s => s.Date)
                .NotEmpty();
            RuleFor(s => s.Distance)
                .NotEmpty();
            RuleFor(s => s.Name)
                .NotEmpty();
        }
    }
}
using FluentValidation;
using ITMCode.Piatnica.Api.DTOs;


namespace ITMCode.Piatnica.Api.DTOs
{
    public class AddEventHistoryDtoValidator : AbstractValidator<AddEventHistoryDto>
    {
        AddEventHistoryDtoValidator()
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

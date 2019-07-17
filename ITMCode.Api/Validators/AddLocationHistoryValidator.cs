using FluentValidation;
using ITMCode.Piatnica.Api.DTOs;

namespace ITMCode.Piatnica.Api.DTOs
{
    public class AddLocationHistoryValidator : AbstractValidator<AddLocationHistoryDto>
    {
        AddLocationHistoryValidator()
        {
            RuleFor(s => s.Date)
                .NotEmpty();
            RuleFor(s => s.Longitude)
                .NotEmpty();
            RuleFor(s => s.LatitudeL)
                .NotEmpty();
        }
    }
}

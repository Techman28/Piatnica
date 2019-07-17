using FluentValidation;
using ITMCode.Piatnica.Api.DTOs;

namespace ITMCode.Piatnica.Api.DTOs
{
    public class UpdateLocationHistoryValidator : AbstractValidator<UpdateLocationHistoryDto>
    {
        UpdateLocationHistoryValidator()
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

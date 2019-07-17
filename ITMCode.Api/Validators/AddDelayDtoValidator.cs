using FluentValidation;
using ITMCode.Piatnica.Api.DTOs;

namespace Dampak.Api.Validators
{
    public class AddDelayDtoValidator : AbstractValidator<AddDelayDto>
    {
        public AddDelayDtoValidator()
        {
            RuleFor(s => s.DelayOrder)
                .NotEmpty();
        }
    }
}


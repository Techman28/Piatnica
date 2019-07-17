using FluentValidation;
using ITMCode.Piatnica.Api.DTOs;

namespace ITMCode.Piatnica.Api.Validators
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


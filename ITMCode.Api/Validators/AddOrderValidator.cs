 using FluentValidation;
using ITMCode.Piatnica.Api.DTOs;

namespace Dampak.Api.Validators
{
    public class AddOrderDtoValidator : AbstractValidator<AddOrderDto>
    {
        public AddOrderDtoValidator()
        {
            RuleFor(s => s.Name)
                .NotEmpty();
        }
    }
}
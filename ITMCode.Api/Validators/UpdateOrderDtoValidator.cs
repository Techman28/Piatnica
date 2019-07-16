using FluentValidation;
using ITMCode.Piatnica.Api.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api.Validators
{
    public class UpdateOrderDtoValidator : AbstractValidator<UpdateDelayDto>
    {
        public UpdateOrderDtoValidator()
        {
            RuleFor(s => s.Number)
                .NotEmpty();
        }
    }
}

using FluentValidation;
using ITMCode.Piatnica.Api.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api.Validators
{
    public class UpdateDelayDtoValidator : AbstractValidator<UpdateDelayDto>
    {
        public UpdateDelayDtoValidator()
        {
            RuleFor(s => s.DelayOrder)
                .NotEmpty();

            RuleFor(s => s.Date)
                .NotEmpty();
        }
    }
}

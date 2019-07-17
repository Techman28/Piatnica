using FluentValidation;
using ITMCode.Piatnica.Api.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api.Validators
{
    public class AddOrderEntryDtoValidator : AbstractValidator<AddOrderEntryDto>
    {
        public AddOrderEntryDtoValidator()
        {
            RuleFor(s => s.Location)
                .NotEmpty();

            RuleFor(s => s.FromTime)
                .NotEmpty();

            RuleFor(s => s.ToTime)
                .NotEmpty();
        }
    }
}

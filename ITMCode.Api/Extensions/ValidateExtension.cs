 
using FluentValidation;
using FluentValidation.Results;
using ITMCode.Piatnica.Api.DTOs;
using ITMCode.Piatnica.Api.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api
{
    public static class ValidateExtension
    {
        public static void Validate<T,T1>(this T1 obj) where T : AbstractValidator<T1> where T1 : IValidatable  
        {
            T validator = Activator.CreateInstance<T>();
            ValidationResult results = validator.Validate(obj);
            if (!results.IsValid)
            {
                throw new MyNotValidException($"Valdiation error", results.Errors.Select(s =>
                    new Error()
                    {
                        Field = s.PropertyName,
                        Message = s.ErrorMessage

                    }).ToList());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api.Exceptions
{
    public class ErrorResponse
    {
        public ErrorResponse()
        {
            Errors = new List<Error>();
        }

        public string StatusCode { get; set; }
        public string Message { get; set; }
        public List<Error> Errors { get; set; }


        public void SetOnlyMessageError(IEnumerable<string> errors)
        {
            Errors = errors.Select(s => new Error() { Message = s }).ToList();
        }


    }
    public class Error
    {
        public string Field { get; set; }
        public string Message { get; set; }

    }
}

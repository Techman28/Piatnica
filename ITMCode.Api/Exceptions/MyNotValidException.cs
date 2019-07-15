using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api.Exceptions
{
    public class MyNotValidException : Exception
    {
        public List<Error> ValidationErrors { get; private set; }

        public MyNotValidException(string message, List<Error> errors = null) : base(message)
        {
            ValidationErrors = errors ?? new List<Error>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api.Exceptions
{
    public class MyRegisterFailedException : Exception
    {

        public IEnumerable<string> Errors { get; }
        public MyRegisterFailedException(string message, IEnumerable<string> errors) : base(message)
        {
            Errors = errors;
        }



    }
}

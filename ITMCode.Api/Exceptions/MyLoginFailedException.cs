using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api.Exceptions
{
    public class MyLoginFailedException : Exception
    {

        public string InternalLoginError { get; } 
        public MyLoginFailedException(string message, string internalLoginError) : base(message)
        {
            InternalLoginError = internalLoginError;
        }
    }
}

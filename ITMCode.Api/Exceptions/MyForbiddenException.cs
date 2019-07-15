using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api.Exceptions
{
    public class MyForbiddenException : Exception
    {

        public string InternalLoginError { get; }
        public MyForbiddenException(string message) : base(message)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api.Exceptions
{
    public class MyNotFoundException : Exception
    {
        public MyNotFoundException(string message) : base(message)
        {
        }
    }
}

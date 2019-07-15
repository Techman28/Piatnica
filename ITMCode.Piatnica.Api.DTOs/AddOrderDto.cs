 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api.DTOs
{
    public class AddOrderDto : IValidatable
    {
        public int Name { get; set; }
    }
}

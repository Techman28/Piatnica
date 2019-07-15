using ITMCode.Piatnica.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Dal.Repository.DelaysRepository
{
    public class DelayRepository : BaseRepository<Delay>, IDelayRepository
    {
        public DelayRepository(PiatnicaContext context) : base(context)
        {

        }


      
    }
}

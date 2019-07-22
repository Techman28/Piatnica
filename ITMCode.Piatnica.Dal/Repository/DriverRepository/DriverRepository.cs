using System;
using System.Collections.Generic;
using System.Text;
using ITMCode.Piatnica.Dal.Models;

namespace ITMCode.Piatnica.Dal.Repository.DriverRepository
{
    class DriverRepository : BaseRepository<Driver>, IDriverRepository
    {
        public DriverRepository(PiatnicaContext context) : base(context)
        {

        }



    }
}

using ITMCode.Piatnica.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Dal.Repository.VechicleRepository

{
    public class VechicleRepository : BaseRepository<Vechicle>, IVechicleRepository
    {
        public VechicleRepository(PiatnicaContext context) : base(context)
        {

        }



    }
}

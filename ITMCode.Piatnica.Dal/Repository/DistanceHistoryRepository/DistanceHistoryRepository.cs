using ITMCode.Piatnica.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Dal.Repository.DistanceHistoryRepository
{
    public class DistanceHistoryRepository: BaseRepository<DistanceHistory>, IDistanceHistoryRepository
    {
        public DistanceHistoryRepository(PiatnicaContext context) : base(context)
        {

        }
    }
}

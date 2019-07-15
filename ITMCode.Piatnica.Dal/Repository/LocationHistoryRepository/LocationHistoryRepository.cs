using ITMCode.Piatnica.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Dal.Repository.LocationHistoryRepository

{
    public class LocationHistoryRepository : BaseRepository<LocationHistory>, ILocationHistoryRepository
    {
        public LocationHistoryRepository(PiatnicaContext context) : base(context)
        {

        }



    }
}

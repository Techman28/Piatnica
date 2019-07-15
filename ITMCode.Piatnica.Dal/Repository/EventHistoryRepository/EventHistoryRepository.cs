using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.Repository.EventHistoryRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Dal.Repository.EventHistory
{
    public class EventHistoryRepository : BaseRepository<Delay>, IEventHistoryRepository
    {
        public EventHistoryRepository(PiatnicaContext context) : base(context)
        {

        }

    }
}

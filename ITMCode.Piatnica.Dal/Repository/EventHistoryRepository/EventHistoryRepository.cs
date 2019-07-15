
using ITMCode.Piatnica.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Dal.Repository.EventHistoryRepository
{
    public class EventHistoryRepository : BaseRepository<EventHistory>, IEventHistoryRepository
    {
        public EventHistoryRepository(PiatnicaContext context) : base(context)
        {

        }

    }
}

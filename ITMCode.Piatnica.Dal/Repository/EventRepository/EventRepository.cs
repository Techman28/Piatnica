using ITMCode.Piatnica.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Dal.Repository.EventRepository
{
   public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(PiatnicaContext context) : base(context)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.Repository;

namespace ITMCode.Piatnica.Dal.Repository.EventHistoryRepository
{
    public interface IEventHistoryRepository : IBaseRepository<EventHistory>, IRepository
    {

    }
}

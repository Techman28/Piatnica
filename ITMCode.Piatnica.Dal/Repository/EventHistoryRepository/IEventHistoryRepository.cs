using System;
using System.Collections.Generic;
using System.Text;
using ITMCode.Piatnica.Dal.Repository;

namespace ITMCode.Piatnica.Dal.Repository.EventHistoryRepository
{
    interface IEventHistoryRepository : IBaseRepository<ITMCode.Piatnica.Dal.Models.EventHistory>, IRepository
    {
    }
}

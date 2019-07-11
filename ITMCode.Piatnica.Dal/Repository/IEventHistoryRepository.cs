using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITMCode.Piatnica.Dal.Models;

namespace ITMCode.Piatnica.Dal.Repository
{
    public interface IEventHistoryRepository
    {
        IEnumerable<EventHistory> GetAll();
        EventHistory GetById(int eventHistoryId);
        void Insert(EventHistory eventHistory);
        void Update(EventHistory eventHistory);
        void Delete(int eventHistoryId);
        void Save();
    }
}
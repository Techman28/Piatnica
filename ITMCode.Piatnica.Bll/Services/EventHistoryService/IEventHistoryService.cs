using System;
using System.Collections.Generic;
using System.Text;
using ITMCode.Piatnica.Bll.Models;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Bll.Services.EventHistoryService
{
    public interface IEventHistoryService : IService
    {
        Task<EventHistoryBllModel> GetAsync(int id);
        Task<EventHistoryBllModel> AddAsync(float distance, DateTime date, string name);
        Task UpdateAsync(int id, EventHistoryBllModel delay);
        Task DeleteAsync(int id);
    }
}

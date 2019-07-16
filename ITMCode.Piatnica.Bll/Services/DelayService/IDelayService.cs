using ITMCode.Piatnica.Bll.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Bll.Services.DelayService
{
    public interface IDelayService : IService
    {
        Task<DelayBllModel> GetAsync(int id);
        Task<DelayBllModel> AddAsync(string number);
        Task UpdateAsync(int id, DelayBllModel delay);
        Task DeleteAsync(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ITMCode.Piatnica.Bll.Models;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Bll.Services.LocationHistoryService
{
     public interface ILocationHistoryService : IService
    {
        Task<LocationHistoryBllModel> GetAsync(int id);
        Task<LocationHistoryBllModel> AddAsync(double Longitude,double LatitudeL, DateTime date);
        Task UpdateAsync(int id, LocationHistoryBllModel locationHistory);
        Task DeleteAsync(int id);
    }
}

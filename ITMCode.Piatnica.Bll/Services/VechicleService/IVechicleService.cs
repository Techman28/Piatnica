using System;
using System.Collections.Generic;
using System.Text;
using ITMCode.Piatnica.Bll.Models;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Bll.Services.VechicleService
{
    public interface IVechicleService : IService
    {
        Task<VechicleBllModel> GetAsync(int id);
        //Task<VechicleBllModel> AddAsync(string brand, string registration,int mileage,int capacity);
        //Task UpdateAsync(int id, VechicleBllModel vechicle);
        //Task DeleteAsync(int id);
    }
}

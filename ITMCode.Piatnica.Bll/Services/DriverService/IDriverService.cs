using System;
using System.Collections.Generic;
using System.Text;
using ITMCode.Piatnica.Bll.Models;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Bll.Services.DriverService
{
    public interface IDriverService : IService
    {
        Task<DriverBllModel> GetAsync(int id);
        Task<DriverBllModel> AddAsync(string name, string surname, int age, string driverLicense, DateTime hiringDate);
        Task UpdateAsync(int id, DriverBllModel driver);
        Task DeleteAsync(int id);
    }
}

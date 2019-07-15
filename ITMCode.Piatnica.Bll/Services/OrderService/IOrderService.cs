using System.Collections.Generic;
using System.Threading.Tasks;
using ITMCode.Piatnica.Bll.Models;

namespace ITMCode.Piatnica.Bll.Services
{
    public interface IOrderService : IService
    {
        Task<List<OrderBllModel>> GetPlacesAsync();
        Task AddAsync(string number);
        Task<OrderBllModel> GetAsync(int id);
    }
}
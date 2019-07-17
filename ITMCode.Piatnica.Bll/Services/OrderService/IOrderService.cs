using System.Collections.Generic;
using System.Threading.Tasks;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Dal.Models;

namespace ITMCode.Piatnica.Bll.Services
{
    public interface IOrderService : IService
    {
        Task<List<OrderBllModel>> GetPlacesAsync();
        Task<OrderBllModel> AddAsync(string number);
        Task<OrderBllModel> GetAsync(int id);
        Task UpdateAsync(int id, OrderBllModel order);
        Task<OrderBllModel> AddAsync(OrderBllModel order);
        Task DeleteAsync(int id);
        Task<OrderEntryBllModel> GetOrderEntryAsync();
        Task<OrderEntryBllModel> GetOrderEntryAsync(int id);
        Task<OrderEntryBllModel> AddOrderEntryAsync(OrderEntryBllModel orderEntry);
        Task<OrderEntryBllModel> UpdateOrderEntryAsync(int id, OrderEntryBllModel orderEntry);
        Task DeleteOrderEntryAsync(int id);
    }
}
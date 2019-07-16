using AutoMapper;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ITMCode.Piatnica.Bll.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<List<OrderBllModel>> GetPlacesAsync()
        {
            var ordersList = await _unitOfWork.DelayRepository.GetAllAsync();
            return _mapper.Map<List<OrderBllModel>>(ordersList);
        }

        public async Task<OrderBllModel> GetAsync(int  id)
        {
            // gdyby trzeba zaciagnac inne taqbele, czyli te relacyjne tabele, to  trzeba zrobic includy
            var order = await _unitOfWork.OrderRepository.FindAsyncDefault(id, i=>i.Include(d=>d.LocationHistories).Include(d=>d.OrderEntries));
            return _mapper.Map<OrderBllModel>(order);
        }



        public async Task<OrderBllModel> AddAsync(string number)
        {

            //uzupełanie modelu
            var newOrder = new OrderBllModel();

            newOrder.Number = number;

            await _unitOfWork.OrderRepository.AddAsync(_mapper.Map<Order>(newOrder));
            await  _unitOfWork.SaveChangesAsync();

            return newOrder;
        }

        public async Task<OrderBllModel> AddAsync(OrderBllModel order)
        {
            var newOrder =  _mapper.Map<Order>(order);
            await _unitOfWork.OrderRepository.AddAsync(newOrder);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<OrderBllModel>(newOrder);
        }

        public async Task UpdateAsync(int id, OrderBllModel order)
        {
            var entity = await _unitOfWork.OrderRepository.FindAsyncDefault(s => s.Id == id);
            if (entity == null)
                return;
            entity.Number = order.Number;
            entity.LocationHistories = _mapper.Map<List<LocationHistory>>(order.LocationHistories);
            entity.OrderEntries = _mapper.Map<List<OrderEntry>>(order.OrderEntries);
            entity.OrderState = _mapper.Map<List<OrderState>>(order.OrderState);
             _unitOfWork.OrderRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {

            var entity = await _unitOfWork.OrderRepository.FindAsyncDefault(id, i => i.Include(d => d.LocationHistories).Include(d => d.OrderEntries).Include(d => d.OrderState));

            _unitOfWork.OrderRepository.Delete(entity);
            _unitOfWork.SaveChanges();

        }
    }
}

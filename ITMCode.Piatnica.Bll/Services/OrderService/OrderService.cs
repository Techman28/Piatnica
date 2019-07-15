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
            var order = await _unitOfWork.OrderRepository.FindAsync(id, i=>i.Include(d=>d.LocationHistories).Include(d=>d.OrderEntries));
            return _mapper.Map<OrderBllModel>(order);
        }

        public async Task AddAsync(string number)
        {

            //uzupełanie modelu
            var newOrder = new OrderBllModel();

            newOrder.Number = number;

            newOrder.OrderEntries.Add(new OrderEntryBllModel() {Status =  2});

            var orderDal = _mapper.Map<Order>(newOrder);

            await _unitOfWork.OrderRepository.AddAsync(orderDal);
            await  _unitOfWork.SaveChangesAsync();


        }
    }
}

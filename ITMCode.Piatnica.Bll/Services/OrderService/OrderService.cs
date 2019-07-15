using AutoMapper;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Dal.UnitOfWork;
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
    }
}

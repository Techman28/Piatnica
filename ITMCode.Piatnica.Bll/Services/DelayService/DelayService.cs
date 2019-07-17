using AutoMapper;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Bll.Services.DelayService
{
    public class DelayService : IDelayService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DelayService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }


        public async Task<DelayBllModel> GetAsync(int id)
        {
            var _delay = await _unitOfWork.DelayRepository.FindAsyncDefault(id);
            return _mapper.Map<DelayBllModel>(_delay);
        }

        public async Task<DelayBllModel> AddAsync(int delayOrder)
        {
            var newDelay = new DelayBllModel();
            await _unitOfWork.DelayRepository.AddAsync(_mapper.Map<Delay>(newDelay));
            await _unitOfWork.SaveChangesAsync();

            return newDelay;
        }

        public async Task<DelayBllModel> AddAsync(DelayBllModel delay)
        {
            var newDelay = _mapper.Map<Delay>(delay);
            await _unitOfWork.DelayRepository.AddAsync(newDelay);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<DelayBllModel>(newDelay);
        }

        public async Task UpdateAsync(int id, DelayBllModel delay)
        {
            var entity = await _unitOfWork.DelayRepository.FindAsyncDefault(s => s.Id == id);
            if (entity == null)
                return;
            entity.Date = delay.Date;
            entity.DelayOrder = delay.DelayOrder;
            _unitOfWork.DelayRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _unitOfWork.DelayRepository.FindAsyncDefault(id, i => i.Include(d => d.OrderEntry));

            _unitOfWork.DelayRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }


    }
}

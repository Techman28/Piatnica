using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.UnitOfWork;

namespace ITMCode.Piatnica.Bll.Services.EventHistoryService
{
    public class EventHistoryService : IEventHistoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EventHistoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }


        public async Task<EventHistoryBllModel> GetAsync(int id)
        {
            var _evntHistory = await _unitOfWork.EventHistoryRepository.FindAsyncDefault(id, i => i.Include(d => d.OrderEntry));
            return _mapper.Map<EventHistoryBllModel>(_evntHistory);
        }

        public async Task<EventHistoryBllModel> AddAsync(float distance, DateTime date, string name)
        {
            var newEventHistory = new EventHistoryBllModel();
            await _unitOfWork.EventHistoryRepository.AddAsync(_mapper.Map<EventHistory>(newEventHistory));
            await _unitOfWork.SaveChangesAsync();

            return newEventHistory;
        }

        public async Task<EventHistoryBllModel> AddAsync(EventHistoryBllModel eventHistory)
        {
            var newEventHistory = _mapper.Map<EventHistory>(eventHistory);
            await _unitOfWork.EventHistoryRepository.AddAsync(newEventHistory);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<EventHistoryBllModel>(newEventHistory);
        }

        public async Task UpdateAsync(int id, EventHistoryBllModel eventHistory)
        {
            var entity = await _unitOfWork.EventHistoryRepository.FindAsyncDefault(s => s.Id == id);
            if (entity == null)
                return;
            entity.Date = eventHistory.Date;
            entity.Distance = eventHistory.Distance;
            entity.Name = eventHistory.Name;            
            _unitOfWork.EventHistoryRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _unitOfWork.EventHistoryRepository.FindAsyncDefault(id, i => i.Include(d => d.OrderEntry));

            _unitOfWork.EventHistoryRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }


    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.UnitOfWork;

namespace ITMCode.Piatnica.Bll.Services.LocationHistoryService
{
    public class LocationHistoryService : ILocationHistoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public LocationHistoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<List<LocationHistoryBllModel>> GetPlacesAsync()
        {
            var locationHistoriesList = await _unitOfWork.LocationHistoryRepository.GetAllAsync();
            return _mapper.Map<List<LocationHistoryBllModel>>(locationHistoriesList);
        }
        public async Task<LocationHistoryBllModel> GetAsync(int id)
        {
            var _locationHistory = await _unitOfWork.LocationHistoryRepository.FindAsyncDefault(id, i => i.Include(d => d.Order));
            return _mapper.Map<LocationHistoryBllModel>(_locationHistory);
        }

        public async Task<LocationHistoryBllModel> AddAsync(double Longitude, double LatitudeL, DateTime date)
        {
            var newLocationHistory = new LocationHistoryBllModel();
            newLocationHistory.LatitudeL = LatitudeL;
            newLocationHistory.Longitude = Longitude;
            newLocationHistory.Date = date;

            await _unitOfWork.LocationHistoryRepository.AddAsync(_mapper.Map<LocationHistory>(newLocationHistory));
            await _unitOfWork.SaveChangesAsync();

            return newLocationHistory;
        }

        public async Task<LocationHistoryBllModel> AddAsync(LocationHistoryBllModel locationHistory)
        {
            var newLocationHistory = _mapper.Map<LocationHistory>(locationHistory);
            await _unitOfWork.LocationHistoryRepository.AddAsync(newLocationHistory);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<LocationHistoryBllModel>(newLocationHistory);
        }

        public async Task UpdateAsync(int id, LocationHistoryBllModel locationHistory)
        {
            var entity = await _unitOfWork.LocationHistoryRepository.FindAsyncDefault(s => s.Id == id);
            if (entity == null)
                return;
            entity.LatitudeL = locationHistory.LatitudeL;
            entity.Longitude = locationHistory.Longitude;
            entity.Date = locationHistory.Date;
            _unitOfWork.LocationHistoryRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _unitOfWork.LocationHistoryRepository.FindAsyncDefault(id, i => i.Include(d => d.Order));

            _unitOfWork.LocationHistoryRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }


    }
}


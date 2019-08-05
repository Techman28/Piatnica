using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.UnitOfWork;


namespace ITMCode.Piatnica.Bll.Services.DriverService
{
    public class DriverService : IDriverService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DriverService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<List<DriverBllModel>> GetPlacesAsync()
        {
            var driversList = await _unitOfWork.DriverRepository.GetAllAsync();
            return _mapper.Map<List<DriverBllModel>>(driversList);
        }
        public async Task<DriverBllModel> GetAsync(int id)
        {
            var driversList = await _unitOfWork.DriverRepository.FindAsyncDefault(id, i => i.Include(d => d.Orders));
            return _mapper.Map<DriverBllModel>(driversList);
        }

        public async Task<DriverBllModel> AddAsync(string name, string surname, int age, string driverLicense, DateTime hiringDate)
        {
            var newDriver = new DriverBllModel();
            newDriver.Name = name;
            newDriver.Surname = surname;
            newDriver.Age = age;
            newDriver.DriverLicense = driverLicense;
            newDriver.HiringDate = hiringDate;


            await _unitOfWork.DriverRepository.AddAsync(_mapper.Map<Driver>(newDriver));
            await _unitOfWork.SaveChangesAsync();

            return newDriver;
        }

        public async Task<DriverBllModel> AddAsync(DriverBllModel driver)
        {
            var newDriver = _mapper.Map<Driver>(driver);
            await _unitOfWork.DriverRepository.AddAsync(newDriver);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<DriverBllModel>(newDriver);
        }

        public async Task UpdateAsync(int id, DriverBllModel driver)
        {
            var entity = await _unitOfWork.DriverRepository.FindAsyncDefault(s => s.Id == id);
            if (entity == null)
                return;
            entity.Name = driver.Name;
            entity.Surname = driver.Surname;
            entity.Age = driver.Age;
            entity.DriverLicense = driver.DriverLicense;
            entity.HiringDate = driver.HiringDate;
            _unitOfWork.DriverRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _unitOfWork.DriverRepository.FindAsyncDefault(id, i => i.Include(d => d.Orders));

            _unitOfWork.DriverRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}

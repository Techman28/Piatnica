using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.UnitOfWork;

namespace ITMCode.Piatnica.Bll.Services.VechicleService
{
    public class VechicleService : IVechicleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public VechicleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<List<VechicleBllModel>> GetPlacesAsync()
        {
            var vechiclesList = await _unitOfWork.VechicleRepository.GetAllAsync();
            return _mapper.Map<List<VechicleBllModel>>(vechiclesList);
        }
        public async Task<VechicleBllModel> GetAsync(int id)
        {
            var vechiclesList = await _unitOfWork.VechicleRepository.FindAsyncDefault(id, i => i.Include(d => d.Orders));
            return _mapper.Map<VechicleBllModel>(vechiclesList);
        }
        //public async Task<VechicleBllModel> AddAsync(string brand, string registration, int mileage, int capacity)
        //{
        //    var newVechicle = new VechicleBllModel();
        //    newVechicle.Brand = brand;
        //    newVechicle.Registration = registration;
        //    newVechicle.Mileage = mileage;
        //    newVechicle.Capacity = capacity;

        //    await _unitOfWork.VechicleRepository.AddAsync(_mapper.Map<Vechicle>(newVechicle));
        //    await _unitOfWork.SaveChangesAsync();

        //    return newVechicle;
        //}

        //public async Task<VechicleBllModel> AddAsync(VechicleBllModel vechicle)
        //{
        //    var newVechicle = _mapper.Map<Vechicle>(vechicle);
        //    await _unitOfWork.VechicleRepository.AddAsync(newVechicle);
        //    await _unitOfWork.SaveChangesAsync();

        //    return _mapper.Map<VechicleBllModel>(newVechicle);
        //}

        //public async Task UpdateAsync(int id, VechicleBllModel vechicle)
        //{
        //    var entity = await _unitOfWork.VechicleRepository.FindAsyncDefault(s => s.Id == id);
        //    if (entity == null)
        //        return;
        //    entity.Brand = vechicle.Brand;
        //    entity.Registration = vechicle.Registration;
        //    entity.Mileage = vechicle.Mileage;
        //    entity.Capacity = vechicle.Capacity;
        //    _unitOfWork.VechicleRepository.Update(entity);
        //    await _unitOfWork.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var entity = await _unitOfWork.VechicleRepository.FindAsyncDefault(id, i => i.Include(d => d.Orders));

        //    _unitOfWork.VechicleRepository.Delete(entity);
        //    _unitOfWork.SaveChanges();
        //}

    }
}


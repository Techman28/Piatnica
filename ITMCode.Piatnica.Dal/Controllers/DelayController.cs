using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.Repository;
using ITMCode.Piatnica.Dal;
using ITMCode.Piatnica.Dal.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace ITMCode.Piatnica.Dal.Controllers
{
    public class DelayController : ApiController
    {
        GenericUnitOfWork _unitOfWork;
        public DelayController()
        {
            _unitOfWork = new GenericUnitOfWork();
        }
        public DelayController(GenericUnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        public ActionResult Index()
        {
            var _delay = _unitOfWork.GetRepoInstance<Delay>().GetAll();
            return Ok(_delay);
        }
        public Delay get(Int32 id)
        {
            return _unitOfWork.GetRepoInstance<Delay>().GetById(id);
        }
        public IEnumerable<Delay> getAll()
        {
            return _unitOfWork.GetRepoInstance<Delay>().GetAll();
        }
        public async Task PostAsync(Delay delay)
        {
            _unitOfWork.GetRepoInstance<Delay>().Insert(delay);
            await _unitOfWork.saveAsync();
        }
        public async Task PutAsync(Int32 id, Delay delay)
        {
            var entity = _unitOfWork.GetRepoInstance<Delay>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.date = delay.date;
            entity.delayOrder = delay.delayOrder;
            entity.OrderEntry = delay.OrderEntry;

            _unitOfWork.GetRepoInstance<Delay>().Update(entity);
            await _unitOfWork.saveAsync();
        }
        public async Task DeleteElement(Int32 id)
        {
            _unitOfWork.GetRepoInstance<Delay>().Delete(id);
            await _unitOfWork.saveAsync();

        }

    }
}
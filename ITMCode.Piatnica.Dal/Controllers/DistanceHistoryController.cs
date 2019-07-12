using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.Repository;
using ITMCode.Piatnica.Dal;
using ITMCode.Piatnica.Dal.UnitOfWork;

namespace ITMCode.Piatnica.Dal.Controllers
{
    public class DistanceHistoryController : Controller
    {
        GenericUnitOfWork _unitOfWork;
        public DistanceHistoryController()
        {
            _unitOfWork = new GenericUnitOfWork();
        }
        public DistanceHistoryController(GenericUnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        public ActionResult Index()
        {
            var _distanceHistory = _unitOfWork.GetRepoInstance<DistanceHistory>().GetAll();
            return View(_distanceHistory);
        }
        public DistanceHistory get(Int32 id)
        {
            return _unitOfWork.GetRepoInstance<DistanceHistory>().GetById(id);
        }
        public IEnumerable<DistanceHistory> getAll()
        {
            return _unitOfWork.GetRepoInstance<DistanceHistory>().GetAll();
        }
        public async Task PostAsync(DistanceHistory _distanceHistory)
        {
            _unitOfWork.GetRepoInstance<DistanceHistory>().Insert(_distanceHistory);
            await _unitOfWork.saveAsync();
        }
        public async Task PutAsync(Int32 id, DistanceHistory _distanceHistory)
        {
            var entity = _unitOfWork.GetRepoInstance<DistanceHistory>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.date = _distanceHistory.date;
            entity.distance = _distanceHistory.distance;
            entity.Event = _distanceHistory.Event;
            entity.order = _distanceHistory.order;
            
            _unitOfWork.GetRepoInstance<DistanceHistory>().Update(entity);
            await _unitOfWork.saveAsync();
        }
        public async Task DeleteElement(Int32 id)
        {
            _unitOfWork.GetRepoInstance<DistanceHistory>().Delete(id);
            await _unitOfWork.saveAsync();

        }

    }
}
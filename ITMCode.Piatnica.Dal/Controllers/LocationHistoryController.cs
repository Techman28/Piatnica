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
    public class LocationHistoryController : ApiController
    {
        GenericUnitOfWork _unitOfWork;
        public LocationHistoryController()
        {
            _unitOfWork = new GenericUnitOfWork();
        }
        public LocationHistoryController(GenericUnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        public ActionResult Index()
        {
            var _locationHistory = _unitOfWork.GetRepoInstance<EventHistory>().GetAll();
            return View(_locationHistory);
        }
        public LocationHistory get(Int32 id)
        {
            return _unitOfWork.GetRepoInstance<LocationHistory>().GetById(id);
        }
        public IEnumerable<LocationHistory> getAll()
        {
            return _unitOfWork.GetRepoInstance<LocationHistory>().GetAll();
        }
        public async Task PostAsync(LocationHistory _locationHistory)
        {
            _unitOfWork.GetRepoInstance<LocationHistory>().Insert(_locationHistory);
            await _unitOfWork.saveAsync();
        }
        public async Task PutAsync(Int32 id, LocationHistory _locationHistory)
        {
            var entity = _unitOfWork.GetRepoInstance<LocationHistory>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.date = _locationHistory.date;
            entity.latitudeL = _locationHistory.latitudeL;
            entity.longitude = _locationHistory.longitude;
            entity.order = _locationHistory.order;
            


            _unitOfWork.GetRepoInstance<LocationHistory>().Update(entity);
            await _unitOfWork.saveAsync();
        }
        public async Task DeleteElement(Int32 id)
        {
            _unitOfWork.GetRepoInstance<LocationHistory>().Delete(id);
            await _unitOfWork.saveAsync();

        }

    }
}
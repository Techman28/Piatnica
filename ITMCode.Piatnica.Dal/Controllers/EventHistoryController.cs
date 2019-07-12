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
    public class EventHistoryController : Controller
    {
        GenericUnitOfWork _unitOfWork;
        public EventHistoryController()
        {
            _unitOfWork = new GenericUnitOfWork();
        }
        public EventHistoryController(GenericUnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        public ActionResult Index()
        {
            var _eventHistory = _unitOfWork.GetRepoInstance<EventHistory>().GetAll();
            return View(_eventHistory);
        }
        public EventHistory get(Int32 id)
        {
            return _unitOfWork.GetRepoInstance<EventHistory>().GetById(id);
        }
        public IEnumerable<EventHistory> getAll()
        {
            return _unitOfWork.GetRepoInstance<EventHistory>().GetAll();
        }
        public async Task PostAsync(EventHistory _event)
        {
            _unitOfWork.GetRepoInstance<EventHistory>().Insert(_event);
            await _unitOfWork.saveAsync();
        }
        public async Task PutAsync(Int32 id, EventHistory _event)
        {
            var entity = _unitOfWork.GetRepoInstance<EventHistory>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.date = _event.date;
            entity.Event = _event.Event;
            entity.OrderEntry = _event.OrderEntry;


            _unitOfWork.GetRepoInstance<EventHistory>().Update(entity);
            await _unitOfWork.saveAsync();
        }
        public async Task DeleteElement(Int32 id)
        {
            _unitOfWork.GetRepoInstance<EventHistory>().Delete(id);
            await _unitOfWork.saveAsync();

        }

    }
}
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
    public class EventController : Controller
    {
        GenericUnitOfWork _unitOfWork;
        public EventController()
        {
            _unitOfWork = new GenericUnitOfWork();
        }
        public EventController(GenericUnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        public ActionResult Index()
        {
            var _event = _unitOfWork.GetRepoInstance<Event>().GetAll();
            return View(_event);
        }
        public Event get(Int32 id)
        {
            return _unitOfWork.GetRepoInstance<Event>().GetById(id);
        }
        public IEnumerable<Event> getAll()
        {
            return _unitOfWork.GetRepoInstance<Event>().GetAll();
        }
        public async Task PostAsync(Event _event)
        {
            _unitOfWork.GetRepoInstance<Event>().Insert(_event);
            await _unitOfWork.saveAsync();
        }
        public async Task PutAsync(Int32 id, Event _event)
        {
            var entity = _unitOfWork.GetRepoInstance<Event>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.name = _event.name;
            entity.EventHistories = _event.EventHistories;
            entity.DistanceHistories = _event.DistanceHistories;
            

            _unitOfWork.GetRepoInstance<Event>().Update(entity);
            await _unitOfWork.saveAsync();
        }
        public async Task DeleteElement(Int32 id)
        {
            _unitOfWork.GetRepoInstance<Event>().Delete(id);
            await _unitOfWork.saveAsync();

        }

    }
}
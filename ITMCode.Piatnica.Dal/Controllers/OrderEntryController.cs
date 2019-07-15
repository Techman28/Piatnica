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
    public class OrderEntryController : Controller
    {
        GenericUnitOfWork _unitOfWork;
        public OrderEntryController()
        {
            _unitOfWork = new GenericUnitOfWork();
        }
        public OrderEntryController(GenericUnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        public ActionResult Index()
        {
            var _orderEntry = _unitOfWork.GetRepoInstance<OrderEntry>().GetAll();
            return View(_orderEntry);
        }
        public OrderEntry get(Int32 id)
        {
            return _unitOfWork.GetRepoInstance<OrderEntry>().GetById(id);
        }
        public IEnumerable<OrderEntry> getAll()
        {
            return _unitOfWork.GetRepoInstance<OrderEntry>().GetAll();
        }
        public async Task PostAsync(OrderEntry _orderEntry)
        {
            _unitOfWork.GetRepoInstance<OrderEntry>().Insert(_orderEntry);
            await _unitOfWork.saveAsync();
        }
        public async Task PutAsync(Int32 id, OrderEntry _orderEntry)
        {
            var entity = _unitOfWork.GetRepoInstance<OrderEntry>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.orderType = _orderEntry.orderType ;
            entity.location = _orderEntry.location;
            entity.date = _orderEntry.date;
            entity.fromTime = _orderEntry.fromTime;
            entity.toTime = _orderEntry.toTime;
            entity.cargo = _orderEntry.cargo;
            entity.comments = _orderEntry.comments;
            entity.status = _orderEntry.status;
            entity.order = _orderEntry.order;
            entity.delays = _orderEntry.delays;
            entity.status = _orderEntry.status;
  

            _unitOfWork.GetRepoInstance<OrderEntry>().Update(entity);
            await _unitOfWork.saveAsync();
        }
        public async Task DeleteElement(Int32 id)
        {
            _unitOfWork.GetRepoInstance<OrderEntry>().Delete(id);
            await _unitOfWork.saveAsync();

        }

    }
}
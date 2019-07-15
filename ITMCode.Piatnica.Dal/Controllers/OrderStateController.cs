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
    public class OrderStateController : Controller
    {
        GenericUnitOfWork _unitOfWork;
        public OrderStateController()
        {
            _unitOfWork = new GenericUnitOfWork();
        }
        public OrderStateController(GenericUnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        public ActionResult Index()
        {
            var _orderEntry = _unitOfWork.GetRepoInstance<OrderState>().GetAll();
            return View(_orderEntry);
        }
        public OrderState get(Int32 id)
        {
            return _unitOfWork.GetRepoInstance<OrderState>().GetById(id);
        }
        public IEnumerable<OrderState> getAll()
        {
            return _unitOfWork.GetRepoInstance<OrderState>().GetAll();
        }
        public async Task PostAsync(OrderState _orderEntry)
        {
            _unitOfWork.GetRepoInstance<OrderState>().Insert(_orderEntry);
            await _unitOfWork.saveAsync();
        }
        public async Task PutAsync(Int32 id, OrderState _orderEntry)
        {
            var entity = _unitOfWork.GetRepoInstance<OrderState>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.date = _orderEntry.date;
            entity.state = _orderEntry.state;
            entity.order = _orderEntry.order;



            _unitOfWork.GetRepoInstance<OrderState>().Update(entity);
            await _unitOfWork.saveAsync();
        }
        public async Task DeleteElement(Int32 id)
        {
            _unitOfWork.GetRepoInstance<OrderState>().Delete(id);
            await _unitOfWork.saveAsync();

        }

    }
}
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
    public class OrderController : Controller
    {
        GenericUnitOfWork _unitOfWork;
        public OrderController()
        {
            _unitOfWork = new GenericUnitOfWork();
        }
        public OrderController(GenericUnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        public ActionResult Index()
        {
            var _order = _unitOfWork.GetRepoInstance<Order>().GetAll();
            return View(_order);
        }
        public Order get(Int32 id)
        {
            return _unitOfWork.GetRepoInstance<Order>().GetById(id);
        }
        public IEnumerable<Order> getAll()
        {
            return _unitOfWork.GetRepoInstance<Order>().GetAll();
        }
        public async Task PostAsync(Order _order)
        {
            _unitOfWork.GetRepoInstance<Order>().Insert(_order);
            await _unitOfWork.saveAsync();
        }
        public async Task PutAsync(Int32 id, Order _order)
        {
            var entity = _unitOfWork.GetRepoInstance<Order>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.number = _order.number;
            entity.locationHistories = _order.locationHistories;
            entity.orderEntries = _order.orderEntries;
            entity.orderState = _order.orderState;
            


            _unitOfWork.GetRepoInstance<Order>().Update(entity);
            await _unitOfWork.saveAsync();
        }
        public async Task DeleteElement(Int32 id)
        {
            _unitOfWork.GetRepoInstance<Order>().Delete(id);
            await _unitOfWork.saveAsync();

        }

    }
}
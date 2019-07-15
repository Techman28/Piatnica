using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCode.Piatnica.Dal.UnitOfWork;
using ITMCode.Piatnica.Dal.Models;


namespace ITMCode.Piatnica.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        UnitOfWork _unitOfWork;
        public OrderController()
        {
            _unitOfWork = new UnitOfWork();
        }
        public OrderController(UnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _order = _unitOfWork.GetRepoInstance<Order>().GetAll();
            return Ok(_order);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.GetRepoInstance<Order>().GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }



        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Order _order)
        {
            _unitOfWork.GetRepoInstance<Order>().Insert(_order);
            _unitOfWork.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order _order)
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
            _unitOfWork.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork.GetRepoInstance<Order>().Delete(id);
            _unitOfWork.SaveChanges();
        }
    }
}

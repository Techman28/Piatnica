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
    public class OrderStateController : ControllerBase
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
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _orderEntry = _unitOfWork.GetRepoInstance<OrderState>().GetAll();
            return Ok(_orderEntry);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.GetRepoInstance<OrderState>().GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }



        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] OrderState _orderEntry)
        {
            _unitOfWork.GetRepoInstance<OrderState>().Insert(_orderEntry);
            _unitOfWork.saveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrderState _orderEntry)
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
            _unitOfWork.saveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork.GetRepoInstance<OrderState>().Delete(id);
            _unitOfWork.saveChanges();
        }
    }
}

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
    public class OrderEntryController : ControllerBase
    {
        UnitOfWork _unitOfWork;
        public OrderEntryController()
        {
            _unitOfWork = new UnitOfWork();
        }
        public OrderEntryController(UnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _orderEntry = _unitOfWork.GetRepoInstance<OrderEntry>().GetAll();
            return Ok(_orderEntry);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.GetRepoInstance<OrderEntry>().GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }



        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] OrderEntry _orderEntry)
        {
            _unitOfWork.GetRepoInstance<OrderEntry>().Insert(_orderEntry);
            _unitOfWork.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrderEntry _orderEntry)
        {

            var entity = _unitOfWork.GetRepoInstance<OrderEntry>().GetById(id);
            if (entity == null)
            {
                return;
            }
            entity.orderType = _orderEntry.orderType;
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
            _unitOfWork.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork.GetRepoInstance<OrderEntry>().Delete(id);
            _unitOfWork.SaveChanges();
        }
    }
}

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
        UnitOfWork _unitOfWork;

        public IUnitOfWork UnitOfWork { get; }

        public OrderStateController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        public OrderStateController(UnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _orderEntry = _unitOfWork.OrderStateRepository.GetAll();
            return Ok(_orderEntry);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.OrderStateRepository.Find(s => s.Id == id));
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
            _unitOfWork.OrderStateRepository.Add(_orderEntry);
            _unitOfWork.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrderState _orderEntry)
        {

            var entity = _unitOfWork.OrderStateRepository.Find(s => s.Id == id);
            if (entity == null)
            {
                return;
            }
           
            entity.date = _orderEntry.date;
            entity.state = _orderEntry.state;
            entity.order = _orderEntry.order;

            _unitOfWork.OrderStateRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var entity = _unitOfWork.OrderStateRepository.Find(s => s.Id == id);

            _unitOfWork.OrderStateRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}

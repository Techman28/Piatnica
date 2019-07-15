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

        public IUnitOfWork UnitOfWork { get; }

        public OrderController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        public OrderController(UnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _order = _unitOfWork.OrderRepository.GetAll();
            return Ok(_order);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.OrderRepository.Find(s => s.Id == id));
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
            _unitOfWork.OrderRepository.Add(_order);
            _unitOfWork.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order _order)
        {

            var entity = _unitOfWork.OrderRepository.Find(s => s.Id == id);
            if (entity == null)
            {
                return;
            }
            entity.Number = _order.Number;
            entity.LocationHistories = _order.LocationHistories;
            entity.OrderEntries = _order.OrderEntries;
            entity.OrderState = _order.OrderState;

            _unitOfWork.OrderRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            var entity = _unitOfWork.OrderRepository.Find(s => s.Id == id);

            _unitOfWork.OrderRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCode.Piatnica.Dal.UnitOfWork;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Bll.Services;
using AutoMapper;
using ITMCode.Piatnica.Api.Models;

namespace ITMCode.Piatnica.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    [ProducesResponseType(401)]
    [ProducesResponseType(403)]
    public class OrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServiceFactory _serviceFactory;
 
        public OrderController(IServiceFactory  serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }
         
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           // var _order = _serviceFactory.OrderService.
            return Ok("");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public  async Task<ActionResult<string>> Get(int id)
        {
                var order =await _serviceFactory.OrderService.GetAsync(id);
                return Ok(_mapper.Map<OrderApiModel>(order));
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

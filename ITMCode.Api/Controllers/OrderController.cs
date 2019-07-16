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
using ITMCode.Piatnica.Api.DTOs;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Api.Validators;
using Dampak.Api.Validators;

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
 
        public OrderController(IServiceFactory  serviceFactory, IMapper mapper)
        {
            _serviceFactory = serviceFactory;
            _mapper = mapper;
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
        public  async Task<ActionResult<OrderApiModel>> Get(int id)
        {
                var order =await _serviceFactory.OrderService.GetAsync(id);
                return Ok(_mapper.Map<OrderApiModel>(order));
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AddOrderDto order)
        {
            order.Validate<AddOrderDtoValidator, AddOrderDto>();
            var orderResult = await _serviceFactory.OrderService.AddAsync(order.Number);

            return Ok(orderResult);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateDelayDto order)
        {
            //potrzebne do walidacji danych
            order.Validate<UpdateOrderDtoValidator, UpdateDelayDto>();
            var orderBll = _mapper.Map<OrderBllModel>(order);
            await _serviceFactory.OrderService.UpdateAsync(id,orderBll);

            return Ok("");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _serviceFactory.OrderService.DeleteAsync(id);

            return Ok("");
           
            
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCode.Piatnica.Dal.UnitOfWork;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Bll.Services;
using AutoMapper;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Api.Models;
using Dampak.Api.Validators;
using ITMCode.Piatnica.Api.DTOs;
using ITMCode.Piatnica.Api.Validators;

namespace ITMCode.Piatnica.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderEntryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServiceFactory _serviceFactory;

        public OrderEntryController(IServiceFactory serviceFactory, IMapper mapper)
        {
            _serviceFactory = serviceFactory;
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            return Ok();
        }
        // GET api/values
        [HttpGet]
        public async Task<OrderEntryApiModel> GetOrderEntryAsync()
        {
            var orderEntries = await _serviceFactory.OrderService.GetOrderEntryAsync();
            return _mapper.Map<OrderEntryApiModel>(orderEntries);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderApiModel>> Get(int id)
        {
                var orderEntry = await _serviceFactory.OrderService.GetOrderEntryAsync(id);
                return Ok(_mapper.Map<OrderEntryApiModel>(orderEntry));
        }



        

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AddOrderEntryDto orderEntry)
        {
            orderEntry.Validate<AddOrderEntryDtoValidator, AddOrderEntryDto>();
            var orderEntryResult = await _serviceFactory.OrderService.AddOrderEntryAsync(_mapper.Map<OrderEntryBllModel>(orderEntry));

            return Ok(orderEntryResult);
        }

    // PUT api/values/5
    [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateOrderEntryDto orderEntry)
        {
            orderEntry.Validate<UpdateOrderEntryDtoValidator, UpdateOrderEntryDto>();
            var orderEntryBll = _mapper.Map<OrderEntryBllModel>(orderEntry);
            await _serviceFactory.OrderService.UpdateOrderEntryAsync(id, orderEntryBll);

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

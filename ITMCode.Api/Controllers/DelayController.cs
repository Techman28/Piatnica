using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCode.Piatnica.Dal.UnitOfWork;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Bll.Services;
using ITMCode.Piatnica.Api.Models;
using AutoMapper;
using ITMCode.Piatnica.Api.DTOs;
using ITMCode.Piatnica.Api.Validators;
using Dampak.Api.Validators;
using ITMCode.Piatnica.Bll.Models;

namespace ITMCode.Piatnica.Api.Controllers
{ 

    [Route("api/[controller]")]
    [ApiController]
    public class DelayController : ControllerBase
    {
         private readonly IServiceFactory _serviceFactory;
         private readonly IMapper _mapper;


        public DelayController(IServiceFactory serviceFactory, IMapper mapper)
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

       // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetAsync(int id)
        {
            var delay = await _serviceFactory.DelayService.GetAsync(id);
            return Ok(_mapper.Map<DelayApiModel>(delay));
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AddDelayDto delay)
        {
            delay.Validate<AddDelayDtoValidator, AddDelayDto>();
            var delayResult = await _serviceFactory.DelayService.AddAsync(delay.DelayOrder);

            return Ok(delayResult);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateDelayDto delay)
        {
            delay.Validate<UpdateDelayDtoValidator, UpdateDelayDto>();
            var delayBll = _mapper.Map<DelayBllModel>(delay);
            await _serviceFactory.DelayService.UpdateAsync(id, delayBll);

            return Ok("");
            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _serviceFactory.DelayService.DeleteAsync(id);

            return Ok("");

        }
    }
}

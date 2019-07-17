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


namespace ITMCode.Piatnica.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    [ProducesResponseType(401)]
    [ProducesResponseType(403)]
    public class EventHistoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServiceFactory _serviceFactory;

        public EventHistoryController(IServiceFactory serviceFactory, IMapper mapper)
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
        public async Task<ActionResult<EventHistoryApiModel>> Get(int id)
        {
            var eventHistory = await _serviceFactory.EventHistoryService.GetAsync(id);
            return Ok(_mapper.Map<EventHistoryApiModel>(eventHistory));
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AddEventHistoryDto eventHistory)
        {
            eventHistory.Validate<AddEventHistoryDtoValidator, AddEventHistoryDto>();
            var eventHistoryResult = await _serviceFactory.EventHistoryService.AddAsync(eventHistory.Distance, eventHistory.Date, eventHistory.Name);

            return Ok(eventHistoryResult);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateEventHistoryDto eventHistory)
        {
            //potrzebne do walidacji danych
            eventHistory.Validate<UpdateEventHistoryDtoValidator, UpdateEventHistoryDto>();
            var eventHistoryBll = _mapper.Map<EventHistoryBllModel>(eventHistory);
            await _serviceFactory.EventHistoryService.UpdateAsync(id, eventHistoryBll);

            return Ok("");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _serviceFactory.EventHistoryService.DeleteAsync(id);

            return Ok("");


        }
    }
}

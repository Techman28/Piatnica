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
    public class LocationHistoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServiceFactory _serviceFactory;

        public LocationHistoryController(IServiceFactory serviceFactory, IMapper mapper)
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
        public async Task<ActionResult<LocationHistoryApiModel>> Get(int id)
        {
            var locationHistory = await _serviceFactory.LocationHistoryService.GetAsync(id);
            return Ok(_mapper.Map<LocationHistoryApiModel>(locationHistory));
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AddLocationHistoryDto locationHistory)
        {
            locationHistory.Validate<AddLocationHistoryValidator, AddLocationHistoryDto>();
            var locationHistoryResult = await _serviceFactory.LocationHistoryService.AddAsync(locationHistory.LatitudeL, locationHistory.Longitude, locationHistory.Date);

            return Ok(locationHistoryResult);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateLocationHistoryDto locationHistory)
        {
            //potrzebne do walidacji danych
            locationHistory.Validate<UpdateLocationHistoryValidator, UpdateLocationHistoryDto>();
            var locationHistoryBll = _mapper.Map<LocationHistoryBllModel>(locationHistory);
            await _serviceFactory.LocationHistoryService.UpdateAsync(id, locationHistoryBll);

            return Ok("");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _serviceFactory.LocationHistoryService.DeleteAsync(id);

            return Ok("");


        }
    }
}

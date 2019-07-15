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
    public class LocationHistoryController : ControllerBase
    {
        GenericUnitOfWork _unitOfWork;
        public LocationHistoryController()
        {
            _unitOfWork = new GenericUnitOfWork();
        }
        public LocationHistoryController(GenericUnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _locationHistory = _unitOfWork.GetRepoInstance<LocationHistory>().GetAll();
            return Ok(_locationHistory);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.GetRepoInstance<LocationHistory>().GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }



        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] LocationHistory _locationHistory)
        {
            _unitOfWork.GetRepoInstance<LocationHistory>().Insert(_locationHistory);
            _unitOfWork.saveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] LocationHistory _locationHistory)
        {

            var entity = _unitOfWork.GetRepoInstance<LocationHistory>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.date = _locationHistory.date;
            entity.latitudeL = _locationHistory.latitudeL;
            entity.longitude = _locationHistory.longitude;
            entity.order = _locationHistory.order;

            _unitOfWork.GetRepoInstance<LocationHistory>().Update(entity);
            _unitOfWork.saveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork.GetRepoInstance<LocationHistory>().Delete(id);
            _unitOfWork.saveChanges();
        }
    }
}

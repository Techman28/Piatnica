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
        UnitOfWork _unitOfWork;

        public IUnitOfWork UnitOfWork { get; }

        public LocationHistoryController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        public LocationHistoryController(UnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _locationHistory = _unitOfWork.LocationHistoryRepository.GetAll();
            return Ok(_locationHistory);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.LocationHistoryRepository.Find(s => s.Id == id));
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
            _unitOfWork.LocationHistoryRepository.Add(_locationHistory);
            _unitOfWork.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] LocationHistory _locationHistory)
        {

            var entity = _unitOfWork.LocationHistoryRepository.Find(s => s.Id == id);
            if (entity == null)
            {
                return;
            }

            entity.Date = _locationHistory.Date;
            entity.LatitudeL = _locationHistory.LatitudeL;
            entity.Longitude = _locationHistory.Longitude;
            entity.OrderId = _locationHistory.OrderId;

            _unitOfWork.LocationHistoryRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var entity = _unitOfWork.LocationHistoryRepository.Find(s => s.Id == id);
            _unitOfWork.LocationHistoryRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}

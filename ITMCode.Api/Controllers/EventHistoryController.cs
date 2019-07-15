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
    public class EventHistoryController : ControllerBase
    {
        UnitOfWork _unitOfWork;

        public IUnitOfWork UnitOfWork { get; }

        public EventHistoryController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        public EventHistoryController(UnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _eventHistory = _unitOfWork.EventHistoryRepository.GetAll();
            return Ok(_eventHistory);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.EventHistoryRepository.Find(s => s.Id == id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }



        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] EventHistory _eventHistory)
        {
            _unitOfWork.EventHistoryRepository.Add(_eventHistory);
            _unitOfWork.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EventHistory _eventHistory)
        {

            var entity = _unitOfWork.EventHistoryRepository.Find(s => s.Id == id);
            if (entity == null)
            {
                return;
            }
            entity.Date = _eventHistory.Date;
            entity.OrderEntry = _eventHistory.OrderEntry;

            _unitOfWork.EventHistoryRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var entity = _unitOfWork.EventHistoryRepository.Find(s => s.Id == id);
            _unitOfWork.EventHistoryRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}

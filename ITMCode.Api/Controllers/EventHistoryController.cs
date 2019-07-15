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
        public EventHistoryController()
        {
            _unitOfWork = new UnitOfWork();
        }
        public EventHistoryController(UnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _eventHistory = _unitOfWork.GetRepoInstance<EventHistory>().GetAll();
            return Ok(_eventHistory);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.GetRepoInstance<EventHistory>().GetById(id));
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
            _unitOfWork.GetRepoInstance<EventHistory>().Insert(_eventHistory);
            _unitOfWork.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EventHistory _eventHistory)
        {

            var entity = _unitOfWork.GetRepoInstance<EventHistory>().GetById(id);
            if (entity == null)
            {
                return;
            }
            entity.date = _eventHistory.date;
            entity.Event = _eventHistory.Event;
            entity.OrderEntry = _eventHistory.OrderEntry;

            _unitOfWork.GetRepoInstance<EventHistory>().Update(entity);
            _unitOfWork.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork.GetRepoInstance<EventHistory>().Delete(id);
            _unitOfWork.SaveChanges();
        }
    }
}

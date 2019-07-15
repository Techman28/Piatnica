using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCode.Piatnica.Dal.UnitOfWork;
using ITMCode.Piatnica.Dal.Models;


namespace ITMCode.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        GenericUnitOfWork _unitOfWork;
        public EventController()
        {
            _unitOfWork = new GenericUnitOfWork();
        }
        public EventController(GenericUnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _event = _unitOfWork.GetRepoInstance<Event>().GetAll();
            return Ok(_event);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.GetRepoInstance<Event>().GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }



        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Event _event)
        {
            _unitOfWork.GetRepoInstance<Event>().Insert(_event);
            _unitOfWork.saveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event _event)
        {

            var entity = _unitOfWork.GetRepoInstance<Event>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.name = _event.name;
            entity.EventHistories = _event.EventHistories;
            entity.DistanceHistories = _event.DistanceHistories;

            _unitOfWork.GetRepoInstance<Event>().Update(entity);
            _unitOfWork.saveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork.GetRepoInstance<Event>().Delete(id);
            _unitOfWork.saveChanges();
        }
    }
}

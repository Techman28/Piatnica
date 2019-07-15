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
    public class DelayController : ControllerBase
    {
        GenericUnitOfWork _unitOfWork;
        public DelayController()
        {
            _unitOfWork = new GenericUnitOfWork();
        }
        public DelayController(GenericUnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _delay = _unitOfWork.GetRepoInstance<Delay>().GetAll();
            return Ok(_delay);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.GetRepoInstance<Delay>().GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }



        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Delay delay)
        {
            _unitOfWork.GetRepoInstance<Delay>().Insert(delay);
            _unitOfWork.saveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Delay delay)
        {

            var entity = _unitOfWork.GetRepoInstance<Delay>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.date = delay.date;
            entity.delayOrder = delay.delayOrder;
            entity.OrderEntry = delay.OrderEntry;

            _unitOfWork.GetRepoInstance<Delay>().Update(entity);
            _unitOfWork.saveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork.GetRepoInstance<Delay>().Delete(id);
            _unitOfWork.saveChanges();
        }
    }
}

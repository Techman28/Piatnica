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
        UnitOfWork _unitOfWork;

        public IUnitOfWork UnitOfWork { get; }

        public DelayController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        public DelayController(UnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _delay = _unitOfWork.DelayRepository.GetAll();  
            return Ok(_delay);
        }

       // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.DelayRepository.Find(s=> s.Id == id));
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
            _unitOfWork.DelayRepository.Add(delay);
            _unitOfWork.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Delay delay)
        {

            var entity = _unitOfWork.DelayRepository.Find(s => s.Id == id);
            if (entity == null)
            {
                return;
            }

            entity.Date = delay.Date;
            entity.DelayOrder = delay.DelayOrder;
            entity.OrderEntry = delay.OrderEntry;

            _unitOfWork.DelayRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var entity = _unitOfWork.DelayRepository.Find(s => s.Id == id);
            _unitOfWork.DelayRepository.Delete(entity);

            _unitOfWork.SaveChanges();
        }
    }
}

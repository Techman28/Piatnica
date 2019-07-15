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
    public class DistanceHistoryController : ControllerBase
    {
 
        public IGenericUnitOfWork _unitOfWork { get; }

        public DistanceHistoryController(IGenericUnitOfWork guw)
        {
            _unitOfWork = guw;
            //if (UoW == null)
            //    _unitOfWork = new GenericUnitOfWork();
            //else
            //    _unitOfWork = UoW;

        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            try
            {
       var _distanceHistory = _unitOfWork.GetRepoInstance<DistanceHistory>().GetAll();
                return Ok(_distanceHistory);
                // pobranie z bazdy

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
     
       
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.GetRepoInstance<DistanceHistory>().GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }



        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] DistanceHistory _distanceHistory)
        {
            _unitOfWork.GetRepoInstance<DistanceHistory>().Insert(_distanceHistory);
            _unitOfWork.saveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DistanceHistory _distanceHistory)
        {

            var entity = _unitOfWork.GetRepoInstance<DistanceHistory>().GetById(id);
            if (entity == null)
            {
                return;
            }

            entity.date = _distanceHistory.date;
            entity.distance = _distanceHistory.distance;
            entity.Event = _distanceHistory.Event;
            entity.order = _distanceHistory.order;

            _unitOfWork.GetRepoInstance<DistanceHistory>().Update(entity);
            _unitOfWork.saveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork.GetRepoInstance<DistanceHistory>().Delete(id);
            _unitOfWork.saveChanges();
        }
    }
}

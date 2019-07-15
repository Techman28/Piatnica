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
    public class OrderEntryController : ControllerBase
    {
        UnitOfWork _unitOfWork;

        public IUnitOfWork UnitOfWork { get; }

        public OrderEntryController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        public OrderEntryController(UnitOfWork UoW)
        {
            _unitOfWork = UoW;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var _orderEntry = _unitOfWork.OrderEntryRepository.GetAll();
            return Ok(_orderEntry);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {

                // pobranie z bazdy
                return Ok(_unitOfWork.OrderEntryRepository.Find(s => s.Id == id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }



        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] OrderEntry _orderEntry)
        {
            _unitOfWork.OrderEntryRepository.Add(_orderEntry);
            _unitOfWork.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrderEntry _orderEntry)
        {

            var entity = _unitOfWork.OrderEntryRepository.Find(s => s.Id == id);
            if (entity == null)
            {
                return;
            }
            entity.OrderType = _orderEntry.OrderType;
            entity.Location = _orderEntry.Location;
            entity.Date = _orderEntry.Date;
            entity.FromTime = _orderEntry.FromTime;
            entity.ToTime = _orderEntry.ToTime;
            entity.Cargo = _orderEntry.Cargo;
            entity.Comments = _orderEntry.Comments;
            entity.Status = _orderEntry.Status;
            entity.Order = _orderEntry.Order;
            entity.Delays = _orderEntry.Delays;
            entity.Status = _orderEntry.Status;


            _unitOfWork.OrderEntryRepository.Update(entity);
            _unitOfWork.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var entity = _unitOfWork.OrderEntryRepository.Find(s => s.Id == id);

            _unitOfWork.OrderEntryRepository.Delete(entity);
            _unitOfWork.SaveChanges();
        }
    }
}

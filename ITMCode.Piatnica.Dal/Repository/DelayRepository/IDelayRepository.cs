using BusinessToBusiness.Dal;
using BusinessToBusiness.Dal.Repositories;
using ITMCode.Piatnica.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Dal.Repository.DelaysRepository
{
   public interface IDelayRepository : IBaseRepository<Delay>, IRepository
    {
    }
}

using System;
using System.Threading.Tasks;
using ITMCode.Piatnica.Dal.Repository;
using ITMCode.Piatnica.Dal.Repository.DelaysRepository;

namespace ITMCode.Piatnica.Dal.UnitOfWork
{
    public interface IUnitOfWork
    {

        IDelayRepository DelayRepository
        {
            get;
        }
 
        Task SaveChangesAsync();
        void SaveChanges();
    }
}
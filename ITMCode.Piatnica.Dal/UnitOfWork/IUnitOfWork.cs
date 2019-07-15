using System;
using System.Threading.Tasks;
using ITMCode.Piatnica.Dal.Repository;
using ITMCode.Piatnica.Dal.Repository.DelaysRepository;
using ITMCode.Piatnica.Dal.Repository.EventHistoryRepository;
using ITMCode.Piatnica.Dal.Repository.LocationHistoryRepository;
using ITMCode.Piatnica.Dal.Repository.OrderEntryRepository;
using ITMCode.Piatnica.Dal.Repository.OrderStateRepository;
using ITMCode.Piatnica.Dal.Repository.OrderRepository;


namespace ITMCode.Piatnica.Dal.UnitOfWork
{
    public interface IUnitOfWork
    {

        IDelayRepository DelayRepository
        {
            get;
        }

       
        IEventHistoryRepository EventHistoryRepository
        {
            get;
        }
        ILocationHistoryRepository LocationHistoryRepository
        {
            get;
        }
        IOrderRepository OrderRepository
        {
            get;
        }
        IOrderEntryRepository OrderEntryRepository
        {
            get;
        }
        IOrderStateRepository OrderStateRepository
        {
            get;
        }




        Task SaveChangesAsync();
        void SaveChanges();
    }
}
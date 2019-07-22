using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITMCode.Piatnica.Dal.Repository;
using ITMCode.Piatnica.Dal.Repository.DelaysRepository;
using ITMCode.Piatnica.Dal.Repository.EventHistoryRepository;
using ITMCode.Piatnica.Dal.Repository.LocationHistoryRepository;
using ITMCode.Piatnica.Dal.Repository.OrderEntryRepository;
using ITMCode.Piatnica.Dal.Repository.OrderStateRepository;
using ITMCode.Piatnica.Dal.Repository.OrderRepository;
using ITMCode.Piatnica.Dal.Repository.VechicleRepository;
using ITMCode.Piatnica.Dal.Repository.DriverRepository;


namespace ITMCode.Piatnica.Dal.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private PiatnicaContext _dbContext;

        //  private PiatnicaContext _dbContext= new PiatnicaContext();
 
        public UnitOfWork(PiatnicaContext db, IDelayRepository delayRepository, IEventHistoryRepository eventHistoryRepository, ILocationHistoryRepository locationHistoryRepository, IOrderRepository orderRepository, IOrderEntryRepository orderEntryRepository, IOrderStateRepository orderStateRepository, IVechicleRepository vechicleRepository, IDriverRepository driverRepository)
        {
            _dbContext = db;
            DelayRepository = delayRepository;
            EventHistoryRepository = eventHistoryRepository;
            LocationHistoryRepository = locationHistoryRepository;
            OrderRepository = orderRepository;
            OrderEntryRepository = orderEntryRepository;
            OrderStateRepository = orderStateRepository;
            VechicleRepository = vechicleRepository;
            DriverRepository = driverRepository;

              
        }
        public IDelayRepository DelayRepository { get; }
        public IEventHistoryRepository EventHistoryRepository { get; }
        public ILocationHistoryRepository LocationHistoryRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IOrderEntryRepository OrderEntryRepository { get; }
        public IOrderStateRepository OrderStateRepository { get; }
        public IVechicleRepository VechicleRepository { get; }
        public IDriverRepository DriverRepository { get; }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
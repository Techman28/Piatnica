using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITMCode.Piatnica.Dal.Repository;
using ITMCode.Piatnica.Dal.Repository.DelaysRepository;

namespace ITMCode.Piatnica.Dal.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private PiatnicaContext _dbContext;

        //  private PiatnicaContext _dbContext= new PiatnicaContext();
 
        public UnitOfWork(PiatnicaContext db, IDelayRepository delayRepository)
        {
            _dbContext = db;
            DelayRepository = delayRepository;
        }
        public IDelayRepository DelayRepository { get; }

 
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
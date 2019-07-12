using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITMCode.Piatnica.Dal.Repository;

namespace ITMCode.Piatnica.Dal.UnitOfWork
{
    public class GenericUnitOfWork : IGenericUnitOfWork
    {
        private PiatnicaContext _dbContext;

        //  private PiatnicaContext _dbContext= new PiatnicaContext();
        public GenericUnitOfWork()
        {
            
        }
        public GenericUnitOfWork(PiatnicaContext db)
        {
            _dbContext = db;
        }
        public Type TheType { get; set; }
        public GenericRepository<T> GetRepoInstance<T>() where T :class{
            return new GenericRepository<T>(_dbContext);
        } 
        public void saveChanges()
        {
            _dbContext.SaveChanges();
        }
        public async Task saveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
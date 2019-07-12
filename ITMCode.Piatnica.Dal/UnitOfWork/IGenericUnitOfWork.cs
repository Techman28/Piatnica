using System;
using System.Threading.Tasks;
using ITMCode.Piatnica.Dal.Repository;

namespace ITMCode.Piatnica.Dal.UnitOfWork
{
    public interface IGenericUnitOfWork
    {
        Type TheType { get; set; }

        GenericRepository<T> GetRepoInstance<T>() where T : class;
        Task saveAsync();
        void saveChanges();
    }
}
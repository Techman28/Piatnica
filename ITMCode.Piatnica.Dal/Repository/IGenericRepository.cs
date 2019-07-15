using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITMCode.Piatnica.Dal.Models;

namespace ITMCode.Piatnica.Dal.Repository
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(Int32 recordID);
        void Insert(T delay);
        void Update(T delay);
        void Delete(Int32 recordID);
        void Save();
    }
}
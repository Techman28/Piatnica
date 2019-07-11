using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITMCode.Piatnica.Dal.Models;

namespace ITMCode.Piatnica.Dal.Repository
{
    public interface IDistanceHistoryRepository
    {
        IEnumerable<DistanceHistory> GetAll();
        DistanceHistory GetById(int distanceHistoryID);
        void Insert(DistanceHistory distanceHistory);
        void Update(DistanceHistory distanceHistory);
        void Delete(int distanceHistoryID);
        void Save();
    }
}
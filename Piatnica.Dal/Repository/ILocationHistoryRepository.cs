﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Piatnica.Dal.Models;

namespace Piatnica.Dal.Repository
{
    public interface ILocationHistoryRepository
    {
        IEnumerable<LocationHistory> GetAll();
        LocationHistory GetById(int locationHistoryId);
        void Insert(LocationHistory locationHistory);
        void Update(LocationHistory locationHistory);
        void Delete(int locationHistoryId);
        void Save();
    }
}
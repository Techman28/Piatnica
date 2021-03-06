﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Piatnica.Dal.Models;

namespace Piatnica.Dal.Repository
{
    public interface IDelayRepository
    {
        IEnumerable<Delay> GetAll();
        Delay GetById(int delayID);
        void Insert(Delay delay);
        void Update(Delay delay);
        void Delete(int delayID);
        void Save();
    }
}
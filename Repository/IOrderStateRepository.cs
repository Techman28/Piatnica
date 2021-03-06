﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITMCode.Piatnica.Dal.Models;

namespace ITMCode.Piatnica.Dal.Repository
{
    public interface IOrderStateRepository
    {
        IEnumerable<OrderState> GetAll();
        OrderState GetById(int orderStateId);
        void Insert(OrderState orderState);
        void Update(OrderState orderState);
        void Delete(int orderStateId);
        void Save();
    }
}
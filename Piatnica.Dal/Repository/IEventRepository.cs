using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Piatnica.Dal.Models;

namespace Piatnica.Dal.Repository
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetAll();
        Event GetById(int eventId);
        void Insert(Event eventO);
        void Update(Event eventO);
        void Delete(int eventId);
        void Save();
    }
}
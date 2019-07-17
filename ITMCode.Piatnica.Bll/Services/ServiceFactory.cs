using ITMCode.Piatnica.Bll.Services.DelayService;
using ITMCode.Piatnica.Bll.Services.EventHistoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Bll.Services
{
    public class ServiceFactory : IServiceFactory
    {
        public ServiceFactory( IOrderService orderService, IDelayService delayService, IEventHistoryService eventHistory)

        {

            OrderService = orderService;
            DelayService = delayService;
            EventHistoryService = eventHistory;
        }
        public IOrderService OrderService { get; }
        public IDelayService DelayService { get; }
        public IEventHistoryService EventHistoryService { get; }
    }
}

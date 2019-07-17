using ITMCode.Piatnica.Bll.Services.DelayService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Bll.Services
{
    public class ServiceFactory : IServiceFactory
    {
        public ServiceFactory( IOrderService orderService, IDelayService delayService)

        {

            OrderService = orderService;
            DelayService = delayService;
        }
        public IOrderService OrderService { get; }
        public IDelayService DelayService { get; }
    }
}

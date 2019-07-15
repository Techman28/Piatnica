using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Bll.Services
{
    public class ServiceFactory : IServiceFactory
    {
        public ServiceFactory( IOrderService orderService)

        {

            OrderService = orderService;
        }
        public IOrderService OrderService { get; }
    }
}

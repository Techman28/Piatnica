using ITMCode.Piatnica.Bll.Services.DelayService;
using ITMCode.Piatnica.Bll.Services.EventHistoryService;
using ITMCode.Piatnica.Bll.Services.LocationHistoryService;
using ITMCode.Piatnica.Bll.Services.VechicleService;
using ITMCode.Piatnica.Bll.Services.DriverService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Bll.Services
{
    public class ServiceFactory : IServiceFactory
    {
        public ServiceFactory( IOrderService orderService, IDelayService delayService, IEventHistoryService eventHistory, ILocationHistoryService locationHistoryService, IVechicleService vechicleService, IDriverService driverService)

        {

            OrderService = orderService;
            DelayService = delayService;
            EventHistoryService = eventHistory;
            LocationHistoryService = locationHistoryService;
            VechicleService = vechicleService;
            DriverService = driverService;
        }
        public IOrderService OrderService { get; }
        public IDelayService DelayService { get; }
        public IEventHistoryService EventHistoryService { get; }
        public ILocationHistoryService LocationHistoryService { get; }
        public IVechicleService VechicleService { get; }
        public IDriverService DriverService { get; }
    }
}

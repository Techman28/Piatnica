
using ITMCode.Piatnica.Bll.Services.DelayService;
using ITMCode.Piatnica.Bll.Services.EventHistoryService;
using ITMCode.Piatnica.Bll.Services.LocationHistoryService;
using ITMCode.Piatnica.Bll.Services.VechicleService;
using ITMCode.Piatnica.Bll.Services.DriverService;

namespace ITMCode.Piatnica.Bll.Services
{
    public interface IServiceFactory
    {
        IOrderService OrderService { get; }
        IDelayService DelayService { get; }

        IEventHistoryService EventHistoryService { get; }
        ILocationHistoryService LocationHistoryService { get; }

        IVechicleService VechicleService { get; }
        IDriverService DriverService { get; }
        

    }
}
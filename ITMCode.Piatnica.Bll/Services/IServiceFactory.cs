
using ITMCode.Piatnica.Bll.Services.DelayService;
using ITMCode.Piatnica.Bll.Services.EventHistoryService;
using ITMCode.Piatnica.Bll.Services.LocationHistoryService;

namespace ITMCode.Piatnica.Bll.Services
{
    public interface IServiceFactory
    {
        IOrderService OrderService { get; }
        IDelayService DelayService { get; }

        IEventHistoryService EventHistoryService { get; }
        ILocationHistoryService LocationHistoryService { get; }

    }
}